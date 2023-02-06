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
    public partial class AddSecretary : Form
    {
        public AddSecretary()
        {
            InitializeComponent();
        }

        //Gereken sekreter sınıfı nesneleri türetildi.
        SecretaryDataAccessLayer secretaryDataAccessLayer = new SecretaryDataAccessLayer();
        EntitiesLayer.Secretary secretary = new EntitiesLayer.Secretary();

        //DataGrid verilerini yenileme işlemi.
        public void RefreshData()
        {
            dataGridView1.DataSource= secretaryDataAccessLayer.GetList();
        }

        //Sayfanın yüklenmesi işlemi.
        private void AddSecretary_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; //Sağ üstte bulunan butonlar devre dışı bırakıldı.
            RefreshData();
            DataBinding(new EntitiesLayer.Secretary());
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
        public void DataBinding(EntitiesLayer.Secretary sc)
        {
            ClearDataBinding();
            this.secretary = sc;
            txtBoxSecretaryName.DataBindings.Add("Text", secretary, "SecretaryName");
            txtBoxSecretarySurname.DataBindings.Add("Text", secretary, "SecretarySurname");
        }

        //Arama işlemi.
        private void txtBoxFindSecretary_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = secretaryDataAccessLayer.GetList(x => x.SecretaryName.Contains(txtBoxFindSecretary.Text));
        }

        //TextBox verilerini temizleme işlemi.
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            DataBinding(new EntitiesLayer.Secretary());
        }

        //Ekleme ve güncelleme işlemi.
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            secretaryDataAccessLayer.AddOrUpdate(secretary);
            secretaryDataAccessLayer.Save();
            RefreshData();
            DataBinding(new EntitiesLayer.Secretary());
        }

        //Silme işlemi.
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int secretaryId = int.Parse(dataGridView1.CurrentRow.Cells["SecretaryID"].Value.ToString());
            secretaryDataAccessLayer.Delete(secretary => secretary.SecretaryID == secretaryId);
            secretaryDataAccessLayer.Save();
            RefreshData();
            DataBinding(new EntitiesLayer.Secretary());
        }

        //Satır seçme işlemi.
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secretaryId = int.Parse(dataGridView1.CurrentRow.Cells["SecretaryID"].Value.ToString());
            DataBinding(secretaryDataAccessLayer.GetByFilter(x => x.SecretaryID == secretaryId));
        }
        //Önceki forma gitme işlemi.
        private void btnBack_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryForm = new SecretaryForm();
            secretaryForm.Show();
            this.Close();
        }
    }
}
