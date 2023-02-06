namespace HospitalAutomation.PresentationLayer
{
    partial class SecretaryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddSecretary = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackgroundImage = global::HospitalAutomation.Properties.Resources.Randevu_1;
            this.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddAppointment.ForeColor = System.Drawing.Color.Red;
            this.btnAddAppointment.Location = new System.Drawing.Point(368, 228);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(181, 210);
            this.btnAddAppointment.TabIndex = 0;
            this.btnAddAppointment.Text = "Randevu";
            this.btnAddAppointment.UseVisualStyleBackColor = true;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackgroundImage = global::HospitalAutomation.Properties.Resources.Doktor_1;
            this.btnAddDoctor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddDoctor.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddDoctor.Location = new System.Drawing.Point(368, 12);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(181, 210);
            this.btnAddDoctor.TabIndex = 1;
            this.btnAddDoctor.Text = "Doktor Ekle";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackgroundImage = global::HospitalAutomation.Properties.Resources.Hasta_1;
            this.btnAddPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddPatient.Location = new System.Drawing.Point(46, 228);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(181, 210);
            this.btnAddPatient.TabIndex = 2;
            this.btnAddPatient.Text = "Hasta Ekle";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddSecretary
            // 
            this.btnAddSecretary.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddSecretary.BackgroundImage = global::HospitalAutomation.Properties.Resources.Adsız;
            this.btnAddSecretary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSecretary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddSecretary.ForeColor = System.Drawing.Color.Crimson;
            this.btnAddSecretary.Location = new System.Drawing.Point(46, 12);
            this.btnAddSecretary.Name = "btnAddSecretary";
            this.btnAddSecretary.Size = new System.Drawing.Size(181, 210);
            this.btnAddSecretary.TabIndex = 3;
            this.btnAddSecretary.Text = "Sekreter Ekle";
            this.btnAddSecretary.UseVisualStyleBackColor = false;
            this.btnAddSecretary.Click += new System.EventHandler(this.btnAddSecretary_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(510, 461);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SecretaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(597, 496);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAddSecretary);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.btnAddAppointment);
            this.Name = "SecretaryForm";
            this.Text = "Sekreter Sayfası";
            this.Load += new System.EventHandler(this.SecretaryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddSecretary;
        private System.Windows.Forms.Button btnBack;
    }
}