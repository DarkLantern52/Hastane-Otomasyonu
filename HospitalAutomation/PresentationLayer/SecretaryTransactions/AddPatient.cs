using HospitalAutomation.DataAccessLayer;
using HospitalAutomation.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.PresentationLayer.Secretary
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        //Gereken sınıf nesneleri türetildi.
        PatientDataAccessLayer patientDataAccessLayer = new PatientDataAccessLayer();
        Patient patient = new Patient();

        //Verileri yenileme işlemi.
        public void RefreshData()
        {
            dataGridView1.DataSource = patientDataAccessLayer.GetList();
        }

        //Sayfanın yüklenmesi işlemi.
        private void AddPatient_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            RefreshData();
            DataBinding(new Patient());
        }
        //DataBinding kaldırma işlemi.
        public void ClearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }

        //Nesnelerle veritabanındaki verileri eşleme işlemi.
        public void DataBinding(Patient pt)
        {
            ClearDataBinding();
            this.patient = pt;
            txtBoxPatientName.DataBindings.Add("Text", patient, "PatientName");
            txtBoxPatientSurname.DataBindings.Add("Text", patient, "PatientSurname");
            txtBoxPatientTelephone.DataBindings.Add("Text", patient, "PatientTelephone");

        }

        //Arama işlemi.
        private void txtBoxFindPatient_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = patientDataAccessLayer.GetList(x => x.PatientName.Contains(txtBoxFindPatient.Text));
        }

        //TextBox'ları temizleme işlemi.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataBinding(new Patient());
        }

        //Ekleme ve güncelleme işlemi.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            patientDataAccessLayer.AddOrUpdate(patient);
            patientDataAccessLayer.Save();
            RefreshData();
            DataBinding(new Patient());
        }

        //Silme işlemi.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int patientId = int.Parse(dataGridView1.CurrentRow.Cells["PatientID"].Value.ToString());
            patientDataAccessLayer.Delete(patient => patient.PatientID == patientId);
            patientDataAccessLayer.Save();
            RefreshData();
            DataBinding(new Patient());
        }
        //Satır seçme işlemi.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int patientId = int.Parse(dataGridView1.CurrentRow.Cells["PatientID"].Value.ToString());
            DataBinding(patientDataAccessLayer.GetByFilter(x => x.PatientID == patientId));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryForm = new SecretaryForm();
            secretaryForm.Show();
            this.Close();
        }
    }
}
