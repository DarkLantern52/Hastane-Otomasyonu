namespace HospitalAutomation.PresentationLayer.SecretaryTransactions
{
    partial class AddSecretary
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
            this.txtBoxSecretarySurname = new System.Windows.Forms.TextBox();
            this.txtBoxSecretaryName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SecretaryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecretaryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecretarySurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFindSecretary = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(232, 433);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpdate.Location = new System.Drawing.Point(119, 433);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 32;
            this.btnUpdate.Text = "Kaydet";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Location = new System.Drawing.Point(8, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 46);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "Yeni";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // txtBoxSecretarySurname
            // 
            this.txtBoxSecretarySurname.Location = new System.Drawing.Point(72, 397);
            this.txtBoxSecretarySurname.Name = "txtBoxSecretarySurname";
            this.txtBoxSecretarySurname.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSecretarySurname.TabIndex = 29;
            // 
            // txtBoxSecretaryName
            // 
            this.txtBoxSecretaryName.Location = new System.Drawing.Point(55, 371);
            this.txtBoxSecretaryName.Name = "txtBoxSecretaryName";
            this.txtBoxSecretaryName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSecretaryName.TabIndex = 28;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SecretaryID,
            this.SecretaryName,
            this.SecretarySurname});
            this.dataGridView1.Location = new System.Drawing.Point(8, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(431, 294);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_1);
            // 
            // SecretaryID
            // 
            this.SecretaryID.DataPropertyName = "SecretaryID";
            this.SecretaryID.HeaderText = "ID";
            this.SecretaryID.Name = "SecretaryID";
            // 
            // SecretaryName
            // 
            this.SecretaryName.DataPropertyName = "SecretaryName";
            this.SecretaryName.HeaderText = "Adı";
            this.SecretaryName.Name = "SecretaryName";
            // 
            // SecretarySurname
            // 
            this.SecretarySurname.DataPropertyName = "SecretarySurname";
            this.SecretarySurname.HeaderText = "Soyadı";
            this.SecretarySurname.Name = "SecretarySurname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Soyisim :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "İsim :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ara :";
            // 
            // txtBoxFindSecretary
            // 
            this.txtBoxFindSecretary.Location = new System.Drawing.Point(49, 23);
            this.txtBoxFindSecretary.Name = "txtBoxFindSecretary";
            this.txtBoxFindSecretary.Size = new System.Drawing.Size(127, 20);
            this.txtBoxFindSecretary.TabIndex = 35;
            this.txtBoxFindSecretary.TextChanged += new System.EventHandler(this.txtBoxFindSecretary_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightCoral;
            this.btnBack.Location = new System.Drawing.Point(364, 480);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 36;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 515);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtBoxFindSecretary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxSecretarySurname);
            this.Controls.Add(this.txtBoxSecretaryName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSecretary";
            this.Text = "Sekreter Ekle";
            this.Load += new System.EventHandler(this.AddSecretary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxSecretarySurname;
        private System.Windows.Forms.TextBox txtBoxSecretaryName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFindSecretary;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecretaryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecretaryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecretarySurname;
        private System.Windows.Forms.Button btnBack;
    }
}