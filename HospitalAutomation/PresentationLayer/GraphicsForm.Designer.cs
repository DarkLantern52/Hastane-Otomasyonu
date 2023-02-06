namespace HospitalAutomation.PresentationLayer
{
    partial class GraphicsForm
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
            this.components = new System.ComponentModel.Container();
            this.btnBack = new System.Windows.Forms.Button();
            this.BranchPatient = new ZedGraph.ZedGraphControl();
            this.DoctorPatient = new ZedGraph.ZedGraphControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xAppointmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDoctorBranch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDoctorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDoctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Peru;
            this.btnBack.Location = new System.Drawing.Point(1102, 517);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 33);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "GERİ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // BranchPatient
            // 
            this.BranchPatient.BackColor = System.Drawing.Color.Silver;
            this.BranchPatient.Location = new System.Drawing.Point(12, 12);
            this.BranchPatient.Name = "BranchPatient";
            this.BranchPatient.ScrollGrace = 0D;
            this.BranchPatient.ScrollMaxX = 0D;
            this.BranchPatient.ScrollMaxY = 0D;
            this.BranchPatient.ScrollMaxY2 = 0D;
            this.BranchPatient.ScrollMinX = 0D;
            this.BranchPatient.ScrollMinY = 0D;
            this.BranchPatient.ScrollMinY2 = 0D;
            this.BranchPatient.Size = new System.Drawing.Size(555, 476);
            this.BranchPatient.TabIndex = 5;
            // 
            // DoctorPatient
            // 
            this.DoctorPatient.Location = new System.Drawing.Point(579, 12);
            this.DoctorPatient.Name = "DoctorPatient";
            this.DoctorPatient.ScrollGrace = 0D;
            this.DoctorPatient.ScrollMaxX = 0D;
            this.DoctorPatient.ScrollMaxY = 0D;
            this.DoctorPatient.ScrollMaxY2 = 0D;
            this.DoctorPatient.ScrollMinX = 0D;
            this.DoctorPatient.ScrollMinY = 0D;
            this.DoctorPatient.ScrollMinY2 = 0D;
            this.DoctorPatient.Size = new System.Drawing.Size(555, 476);
            this.DoctorPatient.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xAppointmentID,
            this.xDoctorBranch,
            this.xDoctorID,
            this.xDoctorName,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 494);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(73, 56);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.Visible = false;
            // 
            // xAppointmentID
            // 
            this.xAppointmentID.DataPropertyName = "AppointmentID";
            this.xAppointmentID.HeaderText = "ID";
            this.xAppointmentID.Name = "xAppointmentID";
            // 
            // xDoctorBranch
            // 
            this.xDoctorBranch.DataPropertyName = "DoctorBranch";
            this.xDoctorBranch.HeaderText = "Bölüm";
            this.xDoctorBranch.Name = "xDoctorBranch";
            // 
            // xDoctorID
            // 
            this.xDoctorID.DataPropertyName = "DoctorID";
            this.xDoctorID.HeaderText = "Doktor ID";
            this.xDoctorID.Name = "xDoctorID";
            // 
            // xDoctorName
            // 
            this.xDoctorName.DataPropertyName = "DoctorName";
            this.xDoctorName.HeaderText = "Doktor Adı";
            this.xDoctorName.Name = "xDoctorName";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PatientID";
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PatientName";
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Date";
            this.Column7.HeaderText = "Column7";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Opinion";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            // 
            // GraphicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1189, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DoctorPatient);
            this.Controls.Add(this.BranchPatient);
            this.Controls.Add(this.btnBack);
            this.Name = "GraphicsForm";
            this.Text = "Grafikler";
            this.Load += new System.EventHandler(this.GraphicsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private ZedGraph.ZedGraphControl BranchPatient;
        private ZedGraph.ZedGraphControl DoctorPatient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn xAppointmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDoctorBranch;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDoctorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDoctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}