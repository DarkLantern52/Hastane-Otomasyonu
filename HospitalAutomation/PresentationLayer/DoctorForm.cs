using HospitalAutomation.DataAccessLayer;
using HospitalAutomation.EntitiesLayer;
using iTextSharp.text.pdf; //PDF işlemleri
using iTextSharp.text; //PDF işlemleri
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Mail; //Mail işlemi
using System.Net;
using System.Text.RegularExpressions;

namespace HospitalAutomation.PresentationLayer
{
    public partial class DoctorForm : Form
    {
        public DoctorForm()
        {
            InitializeComponent();
        }


        //Gereken sınıf nesneleri türetildi.
        viewAppointmentDataAccessLayer vAppointmentDataAccessLayer = new viewAppointmentDataAccessLayer();
        viewAppointment vAppointment = new viewAppointment();


        //Verileri yenileme işlemi.
        public void RefreshData()
        {
            dataGridView1.DataSource = vAppointmentDataAccessLayer.GetList();
        }


        //Sayfanın yüklenme işlemi.
        private void DoctorForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            txtBoxDoctorName.ReadOnly = true;
            txtBoxDoctorBranch.ReadOnly = true;
            txtBoxPatientId.ReadOnly = true;
            txtBoxPatientName.ReadOnly = true;
            //Giriş butonuna basılana kadar görünmeyecek.
            panel1.Visible = false;
            panel2.Visible = false;
            dataGridView1.Visible = false;

            RefreshData();
        }

        //Arama işlemi.
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDoctorName = comboBox2.SelectedValue.ToString();
            dataGridView1.DataSource = vAppointmentDataAccessLayer.GetList().Where(x => x.DoctorName == selectedDoctorName).ToList();
        }

        ////Satır seçme işlemi.
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen satıra göre nesneler dolduruluyor.
            txtBoxDoctorName.Text = dataGridView1.CurrentRow.Cells["dDoctorName"].Value.ToString();
            txtBoxDoctorBranch.Text = dataGridView1.CurrentRow.Cells["dDoctorBranch"].Value.ToString();
            txtBoxPatientId.Text = dataGridView1.CurrentRow.Cells["dPatientID"].Value.ToString();
            txtBoxPatientName.Text = dataGridView1.CurrentRow.Cells["dPatientName"].Value.ToString();
            if (dataGridView1.CurrentRow.Cells["dOpinion"].Value != null)
                txtBoxOpinion.Text = dataGridView1.CurrentRow.Cells["dOpinion"].Value.ToString();
            else
                txtBoxOpinion.Text = "";

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Bu işlem ile doktor hastası hakkında yazılar yazabiliyor ve güncelleniyor..
            vAppointment.AppointmentID = int.Parse(dataGridView1.CurrentRow.Cells["dAppointmentID"].Value.ToString()); ;
            vAppointment.PatientID = int.Parse(dataGridView1.CurrentRow.Cells["dPatientID"].Value.ToString());
            vAppointment.PatientName = dataGridView1.CurrentRow.Cells["dPatientName"].Value.ToString();
            vAppointment.Date = DateTime.Parse(dataGridView1.CurrentRow.Cells["dDate"].Value.ToString());
            vAppointment.DoctorID = int.Parse(dataGridView1.CurrentRow.Cells["dDoctorID"].Value.ToString());
            vAppointment.DoctorName = dataGridView1.CurrentRow.Cells["dDoctorName"].Value.ToString();
            vAppointment.DoctorBranch = dataGridView1.CurrentRow.Cells["dDoctorBranch"].Value.ToString();
            vAppointment.Opinion = txtBoxOpinion.Text;

            vAppointmentDataAccessLayer.AddOrUpdate(vAppointment);
            vAppointmentDataAccessLayer.Save();
            RefreshData();
            //Doktora ait datagrid verilerinin değişmmesi için doktorun sbit kalması sağlandı.
            string selectedDoctorName = comboBox2.SelectedValue.ToString();
            dataGridView1.DataSource = vAppointmentDataAccessLayer.GetList().Where(x => x.DoctorName == selectedDoctorName).ToList();
        }
        //Önceki forma gidern işlem.
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
        //Doktor bu butona basarak sayfadaki panellerin gözükmesini sağlıyor.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
            dataGridView1.Visible = true;

            //Doktorların ID ve isimlerini alma. Bu sayede datagridde ilgili doktorun hastaları çıkıyor.
            List<viewAppointment> doctorList = vAppointmentDataAccessLayer.GetList();
            //combobox1'e doktor ID'lerini atama
            comboBox1.DataSource = doctorList;
            comboBox1.DisplayMember = "DoctorID";
            comboBox1.ValueMember = "DoctorID";
            //combobox2'ye doktor isimlerini atama
            comboBox2.DataSource = doctorList;
            comboBox2.DisplayMember = "DoctorName";
            comboBox2.ValueMember = "DoctorName";
        }
        //Bu butona basılarak nesnelerdeki veriler PDF formatına dönüştürülüp kaydediliyor.
        private void btnSaveAsPdf_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sınıfından bir nesne oluşturdum.
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                //Sadece pdf dosyalarının seçilebileceğini ayarladım.
                saveFileDialog.Filter = "Pdf dosyası (*.pdf)|*.pdf";
                //Dosya adını ayarladım.
                saveFileDialog.FileName = "Randevu Bilgileri.pdf";
                //Kullanıcının önüne gelen ekranda ok tuşuna basarsa işlemler başlar.
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                    {
                        //Pdf dosyasının sayfa boyutunu, kenar boşluklarını belirledim.
                        Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open(); //Dosya açıldı.
                        //Veriler aktarıldı.
                        pdfDoc.Add(new Paragraph("Randevu Bilgileri"));
                        pdfDoc.Add(new Paragraph(" "));
                        pdfDoc.Add(new Paragraph("Doktor Adi: " + txtBoxDoctorName.Text));
                        pdfDoc.Add(new Paragraph("Brans: " + txtBoxDoctorBranch.Text));
                        pdfDoc.Add(new Paragraph("Hasta ID: " + txtBoxPatientId.Text));
                        pdfDoc.Add(new Paragraph("Hasta Adi: " + txtBoxPatientName.Text));
                        pdfDoc.Add(new Paragraph("Doktor Görüsü: " + txtBoxOpinion.Text));
                        pdfDoc.Close();
                        stream.Close();
                    }
                }
            }
        }

        //E-posta ve pdf işlemleri.
        private void btnPosta_Click(object sender, EventArgs e)
        {
            //E-postalardan dolayı hata geldiğini gördüm. Bu yüzden try-catch içine yazdım.
            try
            {
                //E-posta gönderme işlemleri
                string patientEmail = txtBoxPatientEmail.Text; //Hasta e-posta adresi
                string doctorEmail = txtBoxDoctorEmail.Text; //Doktor e-posta adresi
                string doctorEmailPassword = txtDoctorMailPassword.Text; //Doktor e-posta şifresi

                using (var client = new SmtpClient("smtp-mail.outlook.com", 587)) //SMTP sunucusu ve port numarası
                {
                    client.EnableSsl = true; //Güvenli bağlantı için SSL etkinleştirdim.
                    client.Credentials = new NetworkCredential(doctorEmail, doctorEmailPassword); //E-posta adresi ve şifre gönderildi.
                    var mail = new MailMessage(doctorEmail, patientEmail); //Gönderici ve alıcı e-posta adresleri
                    mail.Subject = "Randevu Bilgi"; //E-posta konusu
                    mail.Body = "PDF dosyasına bakınız..."; //E-posta içeriği
                    //PDF işlemleri
                    using (var ms = new MemoryStream())
                    {
                        using (var doc = new Document()) //PDF dokümanı oluşturulur
                        {
                            using (var writer = PdfWriter.GetInstance(doc, ms))
                            {
                                doc.Open(); //Doküman açılır
                                doc.Add(new Paragraph("Doktor Adı: " + txtBoxDoctorName.Text));
                                doc.Add(new Paragraph("Doktor Branşı: " + txtBoxDoctorBranch.Text));
                                doc.Add(new Paragraph("Hasta ID: " + txtBoxPatientId.Text));
                                doc.Add(new Paragraph("Hasta Adı: " + txtBoxPatientName.Text));
                                doc.Add(new Paragraph("Görüş: " + txtBoxOpinion.Text));
                                doc.Close();
                            }
                        }
                        mail.Attachments.Add(new Attachment(ms, "AppointmentInfo.pdf")); //Dosya mesaja eklenir.
                        client.Send(mail); //E-posta gönderilmesi
                        MessageBox.Show("E-posta başarıyla gönderildi!"); //Kullanıcıya bilgi verilir
                    }
                }
            }
            //Oluşan programlar yüzünden program durmasın diye catch kullanıldı ve kullanıcı bilgilendirildi.
            catch (Exception)
            {
                MessageBox.Show("Bir hata meydana geldi. Bilgilerin eksik girilmesinden ya da SmtpException kaynaklı bir hata olabilir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error); //Kullanıcıya bilgi verdim.
            }
        }
    }
}
