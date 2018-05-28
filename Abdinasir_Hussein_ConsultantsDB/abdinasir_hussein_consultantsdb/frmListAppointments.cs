using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abdinasir_Hussein_ConsultantsDB
{
    public partial class frmListAppointments : Form
    {
        public frmListAppointments()
        {
            InitializeComponent();
        }

        private void UpdateReport(DateTime StartDate, DateTime EndDate)
        {

            // TODO: This line of code loads data into the 'Abdinasir_Hussein_ConsultantsDBDataSet.sproc_ListAppointments' table. You can move, or remove it, as needed.
            this.sproc_ListAppointmentsTableAdapter.Fill(this.Abdinasir_Hussein_ConsultantsDBDataSet.sproc_ListAppointments, StartDate, EndDate);

            //pass the date parameter list to the report
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Abdinasir_Hussein_ConsultantsDB.ListAppointments.rdlc";
            List<Microsoft.Reporting.WinForms.ReportParameter> listReportParameter = new List<Microsoft.Reporting.WinForms.ReportParameter>();
            listReportParameter.Add(new Microsoft.Reporting.WinForms.ReportParameter("rpStartDate", Convert.ToString(StartDate)));
            listReportParameter.Add(new Microsoft.Reporting.WinForms.ReportParameter("rpEndDate", Convert.ToString(EndDate)));
            this.reportViewer1.LocalReport.SetParameters(listReportParameter);

            this.reportViewer1.RefreshReport();
        
        }

        private void frmListAppointments_Load(object sender, EventArgs e)
        {
            //declare a date variable to use in this form and to initilise them
            DateTime StartDate = Convert.ToDateTime("January 1 1900");
            DateTime EndDate = Convert.ToDateTime("December 31 2030");

            //make the end date todays date
            EndDate = DateTime.Now;
            //say a month is 30 days timespan parameters D, H, M, S
            TimeSpan aMonth = new System.TimeSpan(30, 0, 0, 0);
            //make the start date 30 days before end date
            StartDate = EndDate.Subtract(aMonth);


            //this will assign the date time pickers controls
            dtpStartDate.Text = Convert.ToString(StartDate);
            dtpEndDate.Text = Convert.ToString(EndDate);

           
            //this calls the update Report function
            this.UpdateReport(StartDate, EndDate);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //declare a date variable to use in this form and to initilise them
            DateTime StartDate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime EndDate = Convert.ToDateTime(dtpEndDate.Text);

            //this calls the update Report function
            this.UpdateReport(StartDate, EndDate);
        }
    }
}
