using HospitalAutomation.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Formun yüklenmesi.
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false; //Sağ üstte bulunan butonlar devre dışı bırakıldı.
        }

        //Sayfalara yönlendirme butonları.
        private void btnSecretary_Click(object sender, EventArgs e)
        {
            SecretaryForm secretaryForm = new SecretaryForm(); //Bir SecretaryForm nesnesi oluşturur.
            secretaryForm.Show(); //Oluşturulan form nesnesini açar.
            this.Hide(); //Bu sayfayı gizler.
        }
        private void btnGraphics_Click(object sender, EventArgs e)
        {
            GraphicsForm graphicsForm = new GraphicsForm(); //Bir GraphicsForm nesnesi oluşturur.
            graphicsForm.Show(); //Oluşturulan form nesnesini açar.
            this.Hide(); //Bu sayfayı gizler.
        }
        private void btnDoctor_Click(object sender, EventArgs e)
        {
            DoctorForm doctorForm = new DoctorForm(); //Bir DoctorForm nesnesi oluşturur.
            doctorForm.Show(); //Oluşturulan form nesnesini açar.
            this.Hide(); //Bu sayfayı gizler.
        }

        //Uygulamadan çıkma butonu.
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Sayfalardan geri gelirken oluşturulan form nesnesi uygulamanın
                                //başladığı sayfa olmadığı için bu şekilde uygulamayı kapattım.    
        }
    }
}
