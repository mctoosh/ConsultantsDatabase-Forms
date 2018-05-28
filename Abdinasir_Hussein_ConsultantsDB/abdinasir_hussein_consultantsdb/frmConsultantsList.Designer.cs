namespace Abdinasir_Hussein_ConsultantsDB
{
    partial class frmConsultantsList
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
            this.lstBoxes = new System.Windows.Forms.ListBox();
            this.p15200790tblMedicalCentreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.abdinasir_Hussein_ConsultantsDBDataSet = new Abdinasir_Hussein_ConsultantsDB.Abdinasir_Hussein_ConsultantsDBDataSet();
            this.p15200790_tblMedicalCentreTableAdapter = new Abdinasir_Hussein_ConsultantsDB.Abdinasir_Hussein_ConsultantsDBDataSetTableAdapters.p15200790_tblMedicalCentreTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblConsultant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p15200790tblMedicalCentreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abdinasir_Hussein_ConsultantsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstBoxes
            // 
            this.lstBoxes.DataSource = this.p15200790tblMedicalCentreBindingSource;
            this.lstBoxes.DisplayMember = "abh_Address";
            this.lstBoxes.FormattingEnabled = true;
            this.lstBoxes.Location = new System.Drawing.Point(12, 122);
            this.lstBoxes.Name = "lstBoxes";
            this.lstBoxes.Size = new System.Drawing.Size(602, 355);
            this.lstBoxes.TabIndex = 0;
            this.lstBoxes.ValueMember = "abh_MedicalCentreNo";
            this.lstBoxes.SelectedIndexChanged += new System.EventHandler(this.lstBoxes_SelectedIndexChanged);
            // 
            // p15200790tblMedicalCentreBindingSource
            // 
            this.p15200790tblMedicalCentreBindingSource.DataMember = "p15200790_tblMedicalCentre";
            this.p15200790tblMedicalCentreBindingSource.DataSource = this.abdinasir_Hussein_ConsultantsDBDataSet;
            // 
            // abdinasir_Hussein_ConsultantsDBDataSet
            // 
            this.abdinasir_Hussein_ConsultantsDBDataSet.DataSetName = "Abdinasir_Hussein_ConsultantsDBDataSet";
            this.abdinasir_Hussein_ConsultantsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // p15200790_tblMedicalCentreTableAdapter
            // 
            this.p15200790_tblMedicalCentreTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(539, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 483);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 483);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 483);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblConsultant
            // 
            this.lblConsultant.AutoSize = true;
            this.lblConsultant.BackColor = System.Drawing.Color.DimGray;
            this.lblConsultant.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultant.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblConsultant.Location = new System.Drawing.Point(13, 13);
            this.lblConsultant.Name = "lblConsultant";
            this.lblConsultant.Size = new System.Drawing.Size(246, 39);
            this.lblConsultant.TabIndex = 5;
            this.lblConsultant.Text = "Medical Centre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "List Of Medical Centre Address\'s";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Abdinasir_Hussein_ConsultantsDB.Properties.Resources.cross1;
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmConsultantsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 552);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConsultant);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstBoxes);
            this.Name = "frmConsultantsList";
            this.Text = "Consultants List";
            this.Activated += new System.EventHandler(this.frmConsultantsList_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p15200790tblMedicalCentreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abdinasir_Hussein_ConsultantsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxes;
        private Abdinasir_Hussein_ConsultantsDBDataSet abdinasir_Hussein_ConsultantsDBDataSet;
        private System.Windows.Forms.BindingSource p15200790tblMedicalCentreBindingSource;
        private Abdinasir_Hussein_ConsultantsDBDataSetTableAdapters.p15200790_tblMedicalCentreTableAdapter p15200790_tblMedicalCentreTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblConsultant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

