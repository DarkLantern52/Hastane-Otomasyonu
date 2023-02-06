using HospitalAutomation.PresentationLayer.Secretary;
using HospitalAutomation.PresentationLayer.SecretaryTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.PresentationLayer
{
    public partial class SecretaryForm : Form
    {
        public SecretaryForm()
        {
            InitializeComponent();
        }

        //Formun yüklenmesi.
        private void SecretaryForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; //Sağ üstte bulunan butonlar devre dışı bırakıldı.
        }

        //Sayfalara yönlendirme işlemleri.
        private void btnAddSecretary_Click(object sender, EventArgs e)
        {
            AddSecretary addSecretary= new AddSecretary(); //Bir AddSecretary nesnesi oluşturdum.
            addSecretary.Show(); //Oluşan form nesnesi açıldı.
            this.Close(); //Bu sayfa kapatıldı.
        }
        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor(); //Bir AddDoctor nesnesi oluşturdum.
            addDoctor.Show(); //Oluşan form nesnesi açıldı.
            this.Close(); //Bu sayfa kapatıldı.
        }
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient(); //Bir AddPatient nesnesi oluşturdum.
            addPatient.Show(); //Oluşan form nesnesi açıldı.
            this.Close(); //Bu sayfa kapatıldı.
        }
        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            AddAppointment addAppointment = new AddAppointment(); //Bir AddAppointment nesnesi oluşturdum.
            addAppointment.Show(); //Oluşan form nesnesi açıldı.
            this.Close(); //Bu sayfa kapatıldı.
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(); //Bir MainForm nesnesi oluşturdum.
            mainForm.Show(); //Oluşan form nesnesi açıldı.
            this.Close(); //Bu sayfa kapatıldı.
        }
    }
}
