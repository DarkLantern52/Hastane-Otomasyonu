namespace HospitalAutomation
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSecretary = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnGraphics = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSecretary
            // 
            this.btnSecretary.BackgroundImage = global::HospitalAutomation.Properties.Resources.Adsız;
            this.btnSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecretary.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnSecretary.Location = new System.Drawing.Point(25, 43);
            this.btnSecretary.Name = "btnSecretary";
            this.btnSecretary.Size = new System.Drawing.Size(178, 205);
            this.btnSecretary.TabIndex = 0;
            this.btnSecretary.Text = "Sekreter Giriş";
            this.btnSecretary.UseVisualStyleBackColor = true;
            this.btnSecretary.Click += new System.EventHandler(this.btnSecretary_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.BackgroundImage = global::HospitalAutomation.Properties.Resources.Doktor_1;
            this.btnDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoctor.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnDoctor.Location = new System.Drawing.Point(495, 43);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(178, 205);
            this.btnDoctor.TabIndex = 1;
            this.btnDoctor.Text = "Doktor Giriş";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnGraphics
            // 
            this.btnGraphics.BackgroundImage = global::HospitalAutomation.Properties.Resources.Grafik_1;
            this.btnGraphics.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGraphics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGraphics.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnGraphics.Location = new System.Drawing.Point(252, 43);
            this.btnGraphics.Name = "btnGraphics";
            this.btnGraphics.Size = new System.Drawing.Size(197, 205);
            this.btnGraphics.TabIndex = 2;
            this.btnGraphics.Text = "Grafikler";
            this.btnGraphics.UseVisualStyleBackColor = true;
            this.btnGraphics.Click += new System.EventHandler(this.btnGraphics_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(613, 271);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = global::HospitalAutomation.Properties.Resources.Hastane_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 319);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGraphics);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnSecretary);
            this.Name = "MainForm";
            this.Text = "Hastane Uygulaması";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSecretary;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnGraphics;
        private System.Windows.Forms.Button btnExit;
    }
}

