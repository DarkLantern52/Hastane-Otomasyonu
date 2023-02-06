namespace HospitalAutomation.PresentationLayer.SecretaryTransactions
{
    partial class AddDoctor
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoctorBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBoxDoctorName = new System.Windows.Forms.TextBox();
            this.txtBoxDoctorSurname = new System.Windows.Forms.TextBox();
            this.txtBoxDoctorTelephone = new System.Windows.Forms.MaskedTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxFindDoctor = new System.Windows.Forms.TextBox();
            this.txtBoxDoctorBranch = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DoctorID,
            this.DoctorName,
            this.DoctorSurname,
            this.DoctorTelephone,
            this.DoctorBranch});
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 294);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // DoctorID
            // 
            this.DoctorID.DataPropertyName = "DoctorID";
            this.DoctorID.HeaderText = "ID";
            this.DoctorID.Name = "DoctorID";
            // 
            // DoctorName
            // 
            this.DoctorName.DataPropertyName = "DoctorName";
            this.DoctorName.HeaderText = "Adı";
            this.DoctorName.Name = "DoctorName";
            // 
            // DoctorSurname
            // 
            this.DoctorSurname.DataPropertyName = "DoctorSurname";
            this.DoctorSurname.HeaderText = "Soyadı";
            this.DoctorSurname.Name = "DoctorSurname";
            // 
            // DoctorTelephone
            // 
            this.DoctorTelephone.DataPropertyName = "DoctorTelephone";
            this.DoctorTelephone.HeaderText = "Telefon Numarası";
            this.DoctorTelephone.Name = "DoctorTelephone";
            // 
            // DoctorBranch
            // 
            this.DoctorBranch.DataPropertyName = "DoctorBranch";
            this.DoctorBranch.HeaderText = "Bölümü";
            this.DoctorBranch.Name = "DoctorBranch";
            // 
            // txtBoxDoctorName
            // 
            this.txtBoxDoctorName.Location = new System.Drawing.Point(51, 372);
            this.txtBoxDoctorName.Name = "txtBoxDoctorName";
            this.txtBoxDoctorName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorName.TabIndex = 5;
            // 
            // txtBoxDoctorSurname
            // 
            this.txtBoxDoctorSurname.Location = new System.Drawing.Point(68, 398);
            this.txtBoxDoctorSurname.Name = "txtBoxDoctorSurname";
            this.txtBoxDoctorSurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorSurname.TabIndex = 6;
            // 
            // txtBoxDoctorTelephone
            // 
            this.txtBoxDoctorTelephone.Location = new System.Drawing.Point(115, 442);
            this.txtBoxDoctorTelephone.Mask = "000-0000";
            this.txtBoxDoctorTelephone.Name = "txtBoxDoctorTelephone";
            this.txtBoxDoctorTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorTelephone.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(12, 516);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 46);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Yeni";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(123, 516);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Kaydet";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(236, 516);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ara :";
            // 
            // txtBoxFindDoctor
            // 
            this.txtBoxFindDoctor.Location = new System.Drawing.Point(48, 22);
            this.txtBoxFindDoctor.Name = "txtBoxFindDoctor";
            this.txtBoxFindDoctor.Size = new System.Drawing.Size(144, 20);
            this.txtBoxFindDoctor.TabIndex = 13;
            this.txtBoxFindDoctor.TextChanged += new System.EventHandler(this.txtBoxFindDoctor_TextChanged);
            // 
            // txtBoxDoctorBranch
            // 
            this.txtBoxDoctorBranch.Location = new System.Drawing.Point(61, 475);
            this.txtBoxDoctorBranch.Name = "txtBoxDoctorBranch";
            this.txtBoxDoctorBranch.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDoctorBranch.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Location = new System.Drawing.Point(713, 560);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxFindDoctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxDoctorTelephone);
            this.Controls.Add(this.txtBoxDoctorBranch);
            this.Controls.Add(this.txtBoxDoctorSurname);
            this.Controls.Add(this.txtBoxDoctorName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AddDoctor";
            this.Text = "Doktor Ekle";
            this.Load += new System.EventHandler(this.AddDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBoxDoctorName;
        private System.Windows.Forms.TextBox txtBoxDoctorSurname;
        private System.Windows.Forms.MaskedTextBox txtBoxDoctorTelephone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxFindDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoctorBranch;
        private System.Windows.Forms.TextBox txtBoxDoctorBranch;
        private System.Windows.Forms.Button btnBack;
    }
}