namespace HospitalAutomation.PresentationLayer.SecretaryTransactions
{
    partial class AddAppointment
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opinion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorView = new System.Windows.Forms.DataGridView();
            this.DoktorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoktorTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientView = new System.Windows.Forms.DataGridView();
            this.HastaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaSoyadı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HastaTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFindBranch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxFindPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxDoctorID = new System.Windows.Forms.TextBox();
            this.txtBoxPatientID = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(698, 497);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(612, 543);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 52);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Kaydet";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AppointmentID,
            this.PatientID,
            this.DoctorID,
            this.Opinion,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(606, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 301);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // AppointmentID
            // 
            this.AppointmentID.DataPropertyName = "AppointmentID";
            this.AppointmentID.HeaderText = "ID";
            this.AppointmentID.Name = "AppointmentID";
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "Hasta ID";
            this.PatientID.Name = "PatientID";
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "Doktor ID";
            this.DoctorID.Name = "DoctorID";
            // 
            // Opinion
            // 
            this.Opinion.DataPropertyName = "Opinion";
            this.Opinion.HeaderText = "Hakkında";
            this.Opinion.Name = "Opinion";
            this.Opinion.Visible = false;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Tarih";
            this.Date.Name = "Date";
            // 
            // doctorView
            // 
            this.doctorView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.doctorView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoktorID,
            this.DoktorName,
            this.DoktorSurname,
            this.DoktorBranch,
            this.DoktorTelephone});
            this.doctorView.Location = new System.Drawing.Point(12, 358);
            this.doctorView.Name = "doctorView";
            this.doctorView.Size = new System.Drawing.Size(522, 241);
            this.doctorView.TabIndex = 12;
            this.doctorView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorView_CellClick);
            // 
            // DoktorID
            // 
            this.DoktorID.DataPropertyName = "DoctorID";
            this.DoktorID.HeaderText = "Doktor ID";
            this.DoktorID.Name = "DoktorID";
            // 
            // DoktorName
            // 
            this.DoktorName.DataPropertyName = "DoctorName";
            this.DoktorName.HeaderText = "Adı";
            this.DoktorName.Name = "DoktorName";
            // 
            // DoktorSurname
            // 
            this.DoktorSurname.DataPropertyName = "DoctorSurname";
            this.DoktorSurname.HeaderText = "Soyadı";
            this.DoktorSurname.Name = "DoktorSurname";
            // 
            // DoktorBranch
            // 
            this.DoktorBranch.DataPropertyName = "DoctorBranch";
            this.DoktorBranch.HeaderText = "Bölümü";
            this.DoktorBranch.Name = "DoktorBranch";
            // 
            // DoktorTelephone
            // 
            this.DoktorTelephone.DataPropertyName = "DoctorTelephone";
            this.DoktorTelephone.HeaderText = "Telefon";
            this.DoktorTelephone.Name = "DoktorTelephone";
            this.DoktorTelephone.Visible = false;
            // 
            // patientView
            // 
            this.patientView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HastaID,
            this.HastaName,
            this.HastaSoyadı,
            this.HastaTelephone});
            this.patientView.Location = new System.Drawing.Point(12, 45);
            this.patientView.Name = "patientView";
            this.patientView.Size = new System.Drawing.Size(522, 241);
            this.patientView.TabIndex = 13;
            this.patientView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.patientView_CellClick);
            // 
            // HastaID
            // 
            this.HastaID.DataPropertyName = "PatientID";
            this.HastaID.HeaderText = "Hasta ID";
            this.HastaID.Name = "HastaID";
            // 
            // HastaName
            // 
            this.HastaName.DataPropertyName = "PatientName";
            this.HastaName.HeaderText = "Adı";
            this.HastaName.Name = "HastaName";
            // 
            // HastaSoyadı
            // 
            this.HastaSoyadı.DataPropertyName = "PatientSurname";
            this.HastaSoyadı.HeaderText = "Soyadı";
            this.HastaSoyadı.Name = "HastaSoyadı";
            // 
            // HastaTelephone
            // 
            this.HastaTelephone.DataPropertyName = "PatientTelephone";
            this.HastaTelephone.HeaderText = "Telefon";
            this.HastaTelephone.Name = "HastaTelephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bölüm Adı :";
            // 
            // txtBoxFindBranch
            // 
            this.txtBoxFindBranch.Location = new System.Drawing.Point(83, 318);
            this.txtBoxFindBranch.Name = "txtBoxFindBranch";
            this.txtBoxFindBranch.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFindBranch.TabIndex = 15;
            this.txtBoxFindBranch.TextChanged += new System.EventHandler(this.txtBoxFindBranch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Hasta Adı :";
            // 
            // txtBoxFindPatient
            // 
            this.txtBoxFindPatient.Location = new System.Drawing.Point(83, 9);
            this.txtBoxFindPatient.Name = "txtBoxFindPatient";
            this.txtBoxFindPatient.Size = new System.Drawing.Size(154, 20);
            this.txtBoxFindPatient.TabIndex = 15;
            this.txtBoxFindPatient.TextChanged += new System.EventHandler(this.txtBoxFindPatient_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(857, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Randevular";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(866, 543);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 52);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(739, 543);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 52);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(632, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Doktor ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Hasta ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 503);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tarih :";
            // 
            // txtBoxDoctorID
            // 
            this.txtBoxDoctorID.Location = new System.Drawing.Point(698, 458);
            this.txtBoxDoctorID.Name = "txtBoxDoctorID";
            this.txtBoxDoctorID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorID.TabIndex = 21;
            // 
            // txtBoxPatientID
            // 
            this.txtBoxPatientID.Location = new System.Drawing.Point(698, 415);
            this.txtBoxPatientID.Name = "txtBoxPatientID";
            this.txtBoxPatientID.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientID.TabIndex = 22;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(1109, 608);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::HospitalAutomation.Properties.Resources.randevu_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 643);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxPatientID);
            this.Controls.Add(this.txtBoxDoctorID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBoxFindPatient);
            this.Controls.Add(this.txtBoxFindBranch);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.patientView);
            this.Controls.Add(this.doctorView);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddAppointment";
            this.Text = "Randevu Ekle";
            this.Load += new System.EventHandler(this.AddAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView doctorView;
        private System.Windows.Forms.DataGridView patientView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFindBranch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxFindPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxDoctorID;
        private System.Windows.Forms.TextBox txtBoxPatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaSoyadı;
        private System.Windows.Forms.DataGridViewTextBoxColumn HastaTelephone;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn AppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opinion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoktorTelephone;
    }
}