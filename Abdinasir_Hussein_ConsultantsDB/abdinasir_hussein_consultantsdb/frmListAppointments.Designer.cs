namespace Abdinasir_Hussein_ConsultantsDB
{
    partial class frmListAppointments
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sproc_ListAppointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Abdinasir_Hussein_ConsultantsDBDataSet = new Abdinasir_Hussein_ConsultantsDB.Abdinasir_Hussein_ConsultantsDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sproc_ListAppointmentsTableAdapter = new Abdinasir_Hussein_ConsultantsDB.Abdinasir_Hussein_ConsultantsDBDataSetTableAdapters.sproc_ListAppointmentsTableAdapter();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sproc_ListAppointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abdinasir_Hussein_ConsultantsDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // sproc_ListAppointmentsBindingSource
            // 
            this.sproc_ListAppointmentsBindingSource.DataMember = "sproc_ListAppointments";
            this.sproc_ListAppointmentsBindingSource.DataSource = this.Abdinasir_Hussein_ConsultantsDBDataSet;
            // 
            // Abdinasir_Hussein_ConsultantsDBDataSet
            // 
            this.Abdinasir_Hussein_ConsultantsDBDataSet.DataSetName = "Abdinasir_Hussein_ConsultantsDBDataSet";
            this.Abdinasir_Hussein_ConsultantsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "ListAppointments";
            reportDataSource2.Value = this.sproc_ListAppointmentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Abdinasir_Hussein_ConsultantsDB.ListAppointments.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 115);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1282, 568);
            this.reportViewer1.TabIndex = 0;
            // 
            // sproc_ListAppointmentsTableAdapter
            // 
            this.sproc_ListAppointmentsTableAdapter.ClearBeforeFill = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(958, 67);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 29);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(245, 72);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 2;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(658, 72);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 3;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblStartDate.Location = new System.Drawing.Point(143, 70);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(96, 22);
            this.lblStartDate.TabIndex = 4;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEndDate.Location = new System.Drawing.Point(562, 70);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(90, 22);
            this.lblEndDate.TabIndex = 5;
            this.lblEndDate.Text = "End Date:";
            // 
            // frmListAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 695);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmListAppointments";
            this.Text = "frmListAppointments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListAppointments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sproc_ListAppointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Abdinasir_Hussein_ConsultantsDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sproc_ListAppointmentsBindingSource;
        private Abdinasir_Hussein_ConsultantsDBDataSet Abdinasir_Hussein_ConsultantsDBDataSet;
        private Abdinasir_Hussein_ConsultantsDBDataSetTableAdapters.sproc_ListAppointmentsTableAdapter sproc_ListAppointmentsTableAdapter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
    }
}