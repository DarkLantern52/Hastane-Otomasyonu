using HospitalAutomation.DataAccessLayer;
using HospitalAutomation.EntitiesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph; //Grafiği kullanmak için çağrıldı.

namespace HospitalAutomation.PresentationLayer
{
    public partial class GraphicsForm : Form
    {
        public GraphicsForm()
        {
            InitializeComponent();
        }

        //Gereken sınıf nesneleri türetildi.
        viewAppointmentDataAccessLayer vAppointmentDataAccessLayer = new viewAppointmentDataAccessLayer();

        //Verileri yenileme işlemi.
        public void RefreshData()
        {
            dataGridView1.DataSource = vAppointmentDataAccessLayer.GetList();
        }

        //Form yüklendi.
        private void GraphicsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;//Sağ üstte bulunan butonlar devre dışı bırakıldı.
            RefreshData(); //DataGridView verileri yenilendi.
            MessageBox.Show("Mouse tekerleği ile tablolardaki tüm verileri görebilirsiniz.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //Bölüm Hasta tablosu için yapılan işlemler;
            //DataGridde dolaşıyor ve her bölüm adını bir sözlüğün keyi olarak ayarlayıp tekrarlarında sayısını arttırıyor.
            Dictionary<string, int> branchs = new Dictionary<string, int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string branchNames = dataGridView1.Rows[i].Cells["xDoctorBranch"].Value.ToString();

                if (!branchs.ContainsKey(branchNames))
                {
                    branchs.Add(branchNames, 0);
                }
                branchs[branchNames]++;
            }
            //Bölüm isimlerini listeye attım.
            string[] x = branchs.Keys.ToArray();
            //Hasta sayılarını listeye attım.
            double[] y = branchs.Values.Select(k => (double)k).ToArray();
            // Grafikte verileri gösterecek bar nesnesini oluşturdum.
            GraphPane pane = BranchPatient.GraphPane;
            BarItem bar = pane.AddBar("Hasta Sayısı", null, y, Color.Blue); //null değeri yerine birazdan Bölüm isimleri gelecek.
            //X ekseninde bölüm isimlerini yerleştirme işlemleri
            pane.XAxis.Title.Text = "Bölümler";
            pane.YAxis.Title.Text = "Hasta Sayısı";
            pane.XAxis.Scale.TextLabels = new string[x.Length]; //for döngüsünde null değerlere atama yapmamak için önceden liste tipinde oluşturdum.
            for (int i = 0; i < x.Length; i++)
            {
                pane.XAxis.Scale.TextLabels[i] = x[i];
            }
            pane.XAxis.Scale.Min = 0;
            pane.XAxis.Scale.Max = x.Length - 1;
            pane.XAxis.Type = AxisType.Text;
            //Grafik eksenlerini otomatik olarak ayarladım.
            BranchPatient.AxisChange();
            //Grafikte veri değerlerini gösterdim.
            BranchPatient.IsShowPointValues = true;
            //Grafikte title gösterdim
            pane.Title.IsVisible = true;
            //Grafikteki başlığın ne olacağını belirledim.
            pane.Title.Text = "Bölümlere Göre Hasta Sayısı";
            
           
            //Doktor Hasta tablosu için yapılan işlemler; (Bölümde yapılan işlemlerin aynısı bu yüzden kopyala yapıştır yapıp değişkenlerin adını değiştirdim.)
            Dictionary<string, int> doctors = new Dictionary<string, int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string doctorNames = dataGridView1.Rows[i].Cells["xDoctorName"].Value.ToString();

                if (!doctors.ContainsKey(doctorNames))
                {
                    doctors.Add(doctorNames, 0);
                }
                doctors[doctorNames]++;
            }
            string[] x1 = doctors.Keys.ToArray();
            double[] y1 = doctors.Values.Select(k => (double)k).ToArray();
            GraphPane pane1 = DoctorPatient.GraphPane;
            BarItem bar1 = pane1.AddBar("Hasta Sayısı", null, y1, Color.Red);
            pane1.XAxis.Title.Text = "Doktorlar";
            pane1.YAxis.Title.Text = "Hasta Sayısı";
            pane1.XAxis.Scale.TextLabels = new string[x1.Length];
            for (int i = 0; i < x1.Length; i++)
            {
                pane1.XAxis.Scale.TextLabels[i] = x1[i];
            }
            pane1.XAxis.Scale.Min = 0;
            pane1.XAxis.Scale.Max = x1.Length - 1;
            pane1.XAxis.Type = AxisType.Text;
            DoctorPatient.AxisChange();
            DoctorPatient.IsShowPointValues = true;
            pane1.Title.IsVisible = true;
            pane1.Title.Text = "Doktorlara Göre Hasta Sayısı";
        }

        //Önceki forma gitme işlemi.
        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }
    }
}
