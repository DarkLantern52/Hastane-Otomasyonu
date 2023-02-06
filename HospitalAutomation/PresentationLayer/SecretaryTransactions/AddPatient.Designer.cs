namespace HospitalAutomation.PresentationLayer.Secretary
{
    partial class AddPatient
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxPatientTelephone = new System.Windows.Forms.MaskedTextBox();
            this.txtBoxPatientSurname = new System.Windows.Forms.TextBox();
            this.txtBoxPatientName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxFindPatient = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(248, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(135, 483);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Kaydet";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(24, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 46);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Yeni";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxPatientTelephone
            // 
            this.txtBoxPatientTelephone.Location = new System.Drawing.Point(123, 449);
            this.txtBoxPatientTelephone.Mask = "000-0000";
            this.txtBoxPatientTelephone.Name = "txtBoxPatientTelephone";
            this.txtBoxPatientTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientTelephone.TabIndex = 19;
            // 
            // txtBoxPatientSurname
            // 
            this.txtBoxPatientSurname.Location = new System.Drawing.Point(76, 405);
            this.txtBoxPatientSurname.Name = "txtBoxPatientSurname";
            this.txtBoxPatientSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientSurname.TabIndex = 18;
            // 
            // txtBoxPatientName
            // 
            this.txtBoxPatientName.Location = new System.Drawing.Point(59, 379);
            this.txtBoxPatientName.Name = "txtBoxPatientName";
            this.txtBoxPatientName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPatientName.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.PatientSurname,
            this.PatientTelephone});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 294);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "ID";
            this.PatientID.Name = "PatientID";
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "Adı";
            this.PatientName.Name = "PatientName";
            // 
            // PatientSurname
            // 
            this.PatientSurname.DataPropertyName = "PatientSurname";
            this.PatientSurname.HeaderText = "Soyadı";
            this.PatientSurname.Name = "PatientSurname";
            // 
            // PatientTelephone
            // 
            this.PatientTelephone.DataPropertyName = "PatientTelephone";
            this.PatientTelephone.HeaderText = "Telefon Numarası";
            this.PatientTelephone.Name = "PatientTelephone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefon Numarası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "İsim :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ara :";
            // 
            // txtBoxFindPatient
            // 
            this.txtBoxFindPatient.Location = new System.Drawing.Point(47, 17);
            this.txtBoxFindPatient.Name = "txtBoxFindPatient";
            this.txtBoxFindPatient.Size = new System.Drawing.Size(129, 20);
            this.txtBoxFindPatient.TabIndex = 25;
            this.txtBoxFindPatient.TextChanged += new System.EventHandler(this.txtBoxFindPatient_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Gray;
            this.btnBack.Location = new System.Drawing.Point(713, 506);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxFindPatient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxPatientTelephone);
            this.Controls.Add(this.txtBoxPatientSurname);
            this.Controls.Add(this.txtBoxPatientName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPatient";
            this.Text = "Hasta Ekle";
            this.Load += new System.EventHandler(this.AddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.MaskedTextBox txtBoxPatientTelephone;
        private System.Windows.Forms.TextBox txtBoxPatientSurname;
        private System.Windows.Forms.TextBox txtBoxPatientName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxFindPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientTelephone;
        private System.Windows.Forms.Button btnBack;
    }
}