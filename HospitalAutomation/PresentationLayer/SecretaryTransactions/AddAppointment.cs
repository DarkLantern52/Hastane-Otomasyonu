using HospitalAutomation.DataAccessLayer;
using HospitalAutomation.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HospitalAutomation.PresentationLayer.SecretaryTransactions
{
    public partial class AddAppointment : Form
    {
        public AddAppointment()
        {
            InitializeComponent();
        }

        //Gereken sınıf nesneleri türetildi.
        DoctorDataAccessLayer doctorDataAccessLayer = new DoctorDataAccessLayer();
        Doctor doctor = new Doctor();
        PatientDataAccessLayer patientDataAccessLayer = new PatientDataAccessLayer();
        Patient patient = new Patient();
        AppointmentDataAccessLayer appointmentDataAccessLayer = new AppointmentDataAccessLayer();
        Appointment appointment= new Appointment();




        //Verileri yenileme işlemi.
        public void RefreshData()
        {
            dataGridView1.DataSource = appointmentDataAccessLayer.GetList();
        }




        //Sayfanın yüklenmesi işlemi.
        private void AddAppointment_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnAdd.Enabled = false;

            //Bu randevu alınacağı zaman geçmiş tarihte değer seçilmesini ve en fazla bir ay sonrasına almayı sağlar.
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now.AddDays(30);

            this.ControlBox = false;
            //Kullanıcı sadece tarihi değiştireceği için ve idleri de tablodan seçeceği için readonly yapıldı.
            txtBoxDoctorID.ReadOnly = true;
            txtBoxPatientID.ReadOnly = true;
            //Tablolara gereken veriler çağrıldı.
            doctorView.DataSource = doctorDataAccessLayer.GetList();
            patientView.DataSource = patientDataAccessLayer.GetList();
            //DataGridView1 verileri yenilendi.
            RefreshData();
            DataBinding(new Appointment());
        }
        




        //DataBinding kaldırma işlemi.
        public void ClearDataBinding()
        {
            foreach (Control item in this.Controls)
            {
                item.DataBindings.Clear();
            }
        }

        public void ClearDataBindingDate()
        {         
                dateTimePicker1.DataBindings.Clear();       
        }


        //Nesnelerle veritabanındaki verileri eşleme işlemi.
        public void DataBinding(Appointment apt)
        {
            //İlgili sayfa nesnelerine datagridview1 verileri bağlandı.
            ClearDataBinding();
            this.appointment = apt;
            dateTimePicker1.DataBindings.Add("Text", appointment, "Date",true);
            txtBoxDoctorID.DataBindings.Add("Text", appointment, "DoctorID",true);
            txtBoxPatientID.DataBindings.Add("Text", appointment, "PatientID",true);
        }
   





        //Arama işlemleri textboxlardaki yazıların değişmesine göre ayarlandı..
        private void txtBoxFindBranch_TextChanged(object sender, EventArgs e)
        {
            doctorView.DataSource = doctorDataAccessLayer.GetList(x => x.DoctorBranch.Contains(txtBoxFindBranch.Text));
        }
        private void txtBoxFindPatient_TextChanged(object sender, EventArgs e)
        {
            patientView.DataSource = patientDataAccessLayer.GetList(x => x.PatientName.Contains(txtBoxFindPatient.Text));
        }





        //Ekleme işlemi.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Tüm satırlar kontrol edilir. 
            foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    //Mevcut satırdaki doctorID ve patientID kısımları değişkenlere aktarılır.
                    string doctorID = row.Cells["DoctorID"].Value.ToString();
                    string patientID = row.Cells["PatientID"].Value.ToString();

                    //Takvimdeki değer kontrol edilir.
                    if (row.Cells["Date"].Value.ToString() == time.ToString())
                    {        
                        //Doktor ve hasta idleri kontrol edilir.
                        if (drID.Equals(doctorID) || ptID.Equals(patientID))
                        {
                            MessageBox.Show("Lütfen hasta ya da doktorun o gün randevusu olmadığını kontrol ediniz.");
                            return;
                        }
                    }
                }                             
            //Bu bloğu yukarıdaki kodun çalışıp çalışmadığını kontrol etmek için koydum.
            if (true)
            {
                appointment.DoctorID = int.Parse(doctorView.CurrentRow.Cells["DoktorID"].Value.ToString());
                appointment.PatientID = int.Parse(patientView.CurrentRow.Cells["HastaID"].Value.ToString());
                appointment.Date = dateTimePicker1.Value;

                //Ekleme metodu çağrıldı.
                appointmentDataAccessLayer.AddOrUpdate(appointment);
                //Kayıt işlemi için çağrıldı.
                appointmentDataAccessLayer.Save();
                RefreshData();
                DataBinding(new Appointment());
            }
            MessageBox.Show("Ekleme başarılı.");
        }








        //Güncelleme işlemi.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
              
                //Mevcut satırdaki doctorID ve patientID kısımları değişkenlere aktarılır.
                string doctorID1 = row.Cells["DoctorID"].Value.ToString();
                string patientID1 = row.Cells["PatientID"].Value.ToString();
                //Takvimdeki değer kontrol edilir.
                if (row.Cells["Date"].Value.ToString() == time.ToString())
                {
                    //Doktor ve hasta idleri kontrol edilir.
                    if (drID1.Equals(doctorID1) || ptID1.Equals(patientID1))
                    {
                        MessageBox.Show("Lütfen hasta ya da doktorun o gün randevusu olmadığını kontrol ediniz.");
                        return;
                    }
                }
            }      
            if (true)
            {
                appointment.Date = dateTimePicker1.Value;
                //Ekleme metodu çağrıldı.
                
                appointmentDataAccessLayer.AddOrUpdate(appointment);
                //Kayıt işlemi için çağrıldı.
                appointmentDataAccessLayer.Save();
                RefreshData();
                DataBinding(new Appointment());
            }
            MessageBox.Show("Güncelleme başarılı.");
        }








        //Silme işlemi.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Seçilen satır silindi.
            int appointmentId = int.Parse(dataGridView1.CurrentRow.Cells["AppointmentID"].Value.ToString());
            appointmentDataAccessLayer.Delete(appointment => appointment.AppointmentID == appointmentId);
            appointmentDataAccessLayer.Save();
            RefreshData();
            DataBinding(new Appointment());
            MessageBox.Show("Silme başarılı.");
        }





        //btnAdd ve btnUpdate kısmında kullandım bu değişkenleri.
        string drID, ptID, drID1, ptID1;

        //Doktor tablosundan seçim işlemi.
        private void doctorView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
                if (e.RowIndex >= 0)
                {
                    string doctorId = doctorView.Rows[e.RowIndex].Cells["DoktorID"].Value.ToString();
                    drID = doctorId;
                    txtBoxDoctorID.Text = doctorId;
                }            
        }





        //Hasta tablosundan seçim işlemi.
        private void patientView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            if (e.RowIndex >= 0)
            {
                string patientId = patientView.Rows[e.RowIndex].Cells["HastaID"].Value.ToString();
                ptID = patientId;
                txtBoxPatientID.Text = patientId;
            }
        }



        int count = 0;
        //Randevu tablosu seçim işlemi.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnAdd.Enabled = false;
            btnDelete.Enabled = true;
            //Buradaki verileri güncelleme işleminde kullandım.
            if (e.RowIndex >= 0)
            {
                //drID1 = txtBoxDoctorID.Text;
                //ptID1 = txtBoxPatientID.Text;
                drID1 = dataGridView1.Rows[e.RowIndex].Cells["DoctorID"].Value.ToString();
                ptID1 = dataGridView1.Rows[e.RowIndex].Cells["PatientID"].Value.ToString();
            }
            //Kullanıcıya bilgilendirici mesaj verildi.
            if (count == 0)
            {
                MessageBox.Show("Sadece tarihi değiştirebilirsiniz.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                count++;
            }
            int appointmentId = int.Parse(dataGridView1.CurrentRow.Cells["AppointmentID"].Value.ToString());
            DataBinding(appointmentDataAccessLayer.GetByFilter(x => x.AppointmentID == appointmentId));
        }




        //btnUpdate kısmında kullandım.
        DateTime time;
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ClearDataBindingDate();
            time = dateTimePicker1.Value;
        }







        //Önceki sayfaya geri gitme işlemi.
        private void btnBack_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryForm = new SecretaryForm();
            secretaryForm.Show();
            this.Close();
        }





    }
}
