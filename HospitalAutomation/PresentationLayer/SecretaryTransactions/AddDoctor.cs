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

namespace HospitalAutomation.PresentationLayer.SecretaryTransactions
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        //Gereken sınıf nesneleri türetildi.
        DoctorDataAccessLayer doctorDataAccessLayer = new DoctorDataAccessLayer();
        Doctor doctor =new Doctor();

        //Verileri yenileme işlemi.
        public void RefreshData()
        {
            dataGridView1.DataSource = doctorDataAccessLayer.GetList();
        }

        //Sayfanın yüklenmesi işlemi.
        private void AddDoctor_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            RefreshData();
            DataBinding(new Doctor());
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
        public void DataBinding(Doctor dr)
        {
            ClearDataBinding();
            this.doctor=dr;
            txtBoxDoctorName.DataBindings.Add("Text",doctor,"DoctorName");
            txtBoxDoctorSurname.DataBindings.Add("Text",doctor, "DoctorSurname");
            txtBoxDoctorTelephone.DataBindings.Add("Text",doctor,"DoctorTelephone");
            txtBoxDoctorBranch.DataBindings.Add("Text", doctor, "DoctorBranch");
        }

        //Arama işlemi.
        private void txtBoxFindDoctor_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = doctorDataAccessLayer.GetList(x => x.DoctorName.Contains(txtBoxFindDoctor.Text));
        }

        //TextBox'ları temizleme işlemi.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataBinding(new Doctor());
        }

        //Ekleme ve güncelleme işlemi.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            doctorDataAccessLayer.AddOrUpdate(doctor);
            doctorDataAccessLayer.Save();
            RefreshData();
            DataBinding(new Doctor());
        }

        //Silme işlemi.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int doctorId = int.Parse(dataGridView1.CurrentRow.Cells["DoctorID"].Value.ToString());
            doctorDataAccessLayer.Delete(doctor => doctor.DoctorID== doctorId);
            doctorDataAccessLayer.Save();
            RefreshData();
            DataBinding(new Doctor());
        }

        //Satır seçme işlemi.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int doctorId = int.Parse(dataGridView1.CurrentRow.Cells["DoctorID"].Value.ToString());
            DataBinding(doctorDataAccessLayer.GetByFilter(x => x.DoctorID==doctorId));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryForm = new SecretaryForm();
            secretaryForm.Show();
            this.Close();
        }
    }
}
