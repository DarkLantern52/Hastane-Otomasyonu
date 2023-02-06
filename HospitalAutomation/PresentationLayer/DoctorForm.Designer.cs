namespace HospitalAutomation.PresentationLayer
{
    partial class DoctorForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOpinion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDoctorBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDoctorMailPassword = new System.Windows.Forms.TextBox();
            this.txtBoxDoctorEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPatientEmail = new System.Windows.Forms.TextBox();
            this.btnPosta = new System.Windows.Forms.Button();
            this.btnSaveAsPdf = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxOpinion = new System.Windows.Forms.TextBox();
            this.txtBoxDoctorBranch = new System.Windows.Forms.TextBox();
            this.txtBoxPatientName = new System.Windows.Forms.TextBox();
            this.txtBoxPatientId = new System.Windows.Forms.TextBox();
            this.txtBoxDoctorName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dAppointmentID,
            this.dPatientID,
            this.dPatientName,
            this.dOpinion,
            this.dDate,
            this.dDoctorID,
            this.dDoctorName,
            this.dDoctorBranch});
            this.dataGridView1.Location = new System.Drawing.Point(238, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dAppointmentID
            // 
            this.dAppointmentID.DataPropertyName = "AppointmentID";
            this.dAppointmentID.HeaderText = "Randevu ID";
            this.dAppointmentID.Name = "dAppointmentID";
            // 
            // dPatientID
            // 
            this.dPatientID.DataPropertyName = "PatientID";
            this.dPatientID.HeaderText = "Hasta ID";
            this.dPatientID.Name = "dPatientID";
            // 
            // dPatientName
            // 
            this.dPatientName.DataPropertyName = "PatientName";
            this.dPatientName.HeaderText = "Hasta Adı";
            this.dPatientName.Name = "dPatientName";
            // 
            // dOpinion
            // 
            this.dOpinion.DataPropertyName = "Opinion";
            this.dOpinion.HeaderText = "Sonuçlar";
            this.dOpinion.Name = "dOpinion";
            // 
            // dDate
            // 
            this.dDate.DataPropertyName = "Date";
            this.dDate.HeaderText = "Tarih";
            this.dDate.Name = "dDate";
            // 
            // dDoctorID
            // 
            this.dDoctorID.DataPropertyName = "DoctorID";
            this.dDoctorID.HeaderText = "Doktor ID";
            this.dDoctorID.Name = "dDoctorID";
            // 
            // dDoctorName
            // 
            this.dDoctorName.DataPropertyName = "DoctorName";
            this.dDoctorName.HeaderText = "Doktor Adı";
            this.dDoctorName.Name = "dDoctorName";
            // 
            // dDoctorBranch
            // 
            this.dDoctorBranch.DataPropertyName = "DoctorBranch";
            this.dDoctorBranch.HeaderText = "Bölüm";
            this.dDoctorBranch.Name = "dDoctorBranch";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(48, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(137, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "İsim :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(12, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 143);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Giriş:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightCoral;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtDoctorMailPassword);
            this.panel2.Controls.Add(this.txtBoxDoctorEmail);
            this.panel2.Controls.Add(this.txtBoxPatientEmail);
            this.panel2.Controls.Add(this.btnPosta);
            this.panel2.Controls.Add(this.btnSaveAsPdf);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.txtBoxOpinion);
            this.panel2.Controls.Add(this.txtBoxDoctorBranch);
            this.panel2.Controls.Add(this.txtBoxPatientName);
            this.panel2.Controls.Add(this.txtBoxPatientId);
            this.panel2.Controls.Add(this.txtBoxDoctorName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(426, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 380);
            this.panel2.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(230, 312);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Şifre";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 344);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Hasta E-mail :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Doktor E-mail :";
            // 
            // txtDoctorMailPassword
            // 
            this.txtDoctorMailPassword.Location = new System.Drawing.Point(264, 309);
            this.txtDoctorMailPassword.Name = "txtDoctorMailPassword";
            this.txtDoctorMailPassword.PasswordChar = '*';
            this.txtDoctorMailPassword.Size = new System.Drawing.Size(121, 20);
            this.txtDoctorMailPassword.TabIndex = 10;
            // 
            // txtBoxDoctorEmail
            // 
            this.txtBoxDoctorEmail.Location = new System.Drawing.Point(99, 309);
            this.txtBoxDoctorEmail.Name = "txtBoxDoctorEmail";
            this.txtBoxDoctorEmail.Size = new System.Drawing.Size(121, 20);
            this.txtBoxDoctorEmail.TabIndex = 10;
            // 
            // txtBoxPatientEmail
            // 
            this.txtBoxPatientEmail.Location = new System.Drawing.Point(99, 344);
            this.txtBoxPatientEmail.Name = "txtBoxPatientEmail";
            this.txtBoxPatientEmail.Size = new System.Drawing.Size(121, 20);
            this.txtBoxPatientEmail.TabIndex = 10;
            // 
            // btnPosta
            // 
            this.btnPosta.Location = new System.Drawing.Point(291, 339);
            this.btnPosta.Name = "btnPosta";
            this.btnPosta.Size = new System.Drawing.Size(75, 23);
            this.btnPosta.TabIndex = 9;
            this.btnPosta.Text = "GÖNDER";
            this.btnPosta.UseVisualStyleBackColor = true;
            this.btnPosta.Click += new System.EventHandler(this.btnPosta_Click);
            // 
            // btnSaveAsPdf
            // 
            this.btnSaveAsPdf.Location = new System.Drawing.Point(440, 326);
            this.btnSaveAsPdf.Name = "btnSaveAsPdf";
            this.btnSaveAsPdf.Size = new System.Drawing.Size(75, 23);
            this.btnSaveAsPdf.TabIndex = 8;
            this.btnSaveAsPdf.Text = "PDF YAP";
            this.btnSaveAsPdf.UseVisualStyleBackColor = true;
            this.btnSaveAsPdf.Click += new System.EventHandler(this.btnSaveAsPdf_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(440, 297);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxOpinion
            // 
            this.txtBoxOpinion.Location = new System.Drawing.Point(65, 128);
            this.txtBoxOpinion.Multiline = true;
            this.txtBoxOpinion.Name = "txtBoxOpinion";
            this.txtBoxOpinion.Size = new System.Drawing.Size(450, 156);
            this.txtBoxOpinion.TabIndex = 5;
            // 
            // txtBoxDoctorBranch
            // 
            this.txtBoxDoctorBranch.Location = new System.Drawing.Point(226, 11);
            this.txtBoxDoctorBranch.Name = "txtBoxDoctorBranch";
            this.txtBoxDoctorBranch.ReadOnly = true;
            this.txtBoxDoctorBranch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorBranch.TabIndex = 4;
            // 
            // txtBoxPatientName
            // 
            this.txtBoxPatientName.Location = new System.Drawing.Point(65, 92);
            this.txtBoxPatientName.Name = "txtBoxPatientName";
            this.txtBoxPatientName.ReadOnly = true;
            this.txtBoxPatientName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientName.TabIndex = 3;
            // 
            // txtBoxPatientId
            // 
            this.txtBoxPatientId.Location = new System.Drawing.Point(65, 59);
            this.txtBoxPatientId.Name = "txtBoxPatientId";
            this.txtBoxPatientId.ReadOnly = true;
            this.txtBoxPatientId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientId.TabIndex = 3;
            // 
            // txtBoxDoctorName
            // 
            this.txtBoxDoctorName.Location = new System.Drawing.Point(65, 11);
            this.txtBoxDoctorName.Name = "txtBoxDoctorName";
            this.txtBoxDoctorName.ReadOnly = true;
            this.txtBoxDoctorName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorName.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Doktor :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bölüm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Hasta ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sonuçlar :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hasta Adı :";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1105, 731);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::HospitalAutomation.Properties.Resources.login_1;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Location = new System.Drawing.Point(12, 12);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(203, 89);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.BackgroundImage = global::HospitalAutomation.Properties.Resources.Hastane_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 758);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DoctorForm";
            this.Text = "Doktor Sayfası";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOpinion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDoctorBranch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxOpinion;
        private System.Windows.Forms.TextBox txtBoxDoctorBranch;
        private System.Windows.Forms.TextBox txtBoxPatientName;
        private System.Windows.Forms.TextBox txtBoxPatientId;
        private System.Windows.Forms.TextBox txtBoxDoctorName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnSaveAsPdf;
        private System.Windows.Forms.Button btnPosta;
        private System.Windows.Forms.TextBox txtBoxPatientEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxDoctorEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDoctorMailPassword;
    }
}