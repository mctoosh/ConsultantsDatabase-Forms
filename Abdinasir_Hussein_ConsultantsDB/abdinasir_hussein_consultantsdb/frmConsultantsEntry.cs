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
    public partial class frmConsultantsEntry : Form
    {
        public frmConsultantsEntry()
        {
            InitializeComponent();
        }

        private void p15200790_tblMedicalCentreBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.p15200790_tblMedicalCentreBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.abdinasir_Hussein_ConsultantsDBDataSet);

        }

        private void frmConsultantsEntry_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblPracticeGP' table. You can move, or remove it, as needed.
            this.p15200790_tblPracticeGPTableAdapter.Fill(this.abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblPracticeGP);
            // TODO: This line of code loads data into the 'abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblMedicalCentre' table. You can move, or remove it, as needed.
            this.p15200790_tblMedicalCentreTableAdapter.Fill(this.abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblMedicalCentre);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FindCentre(int abh_MedicalCentreNo)
        {
            //Public Procedure to show the details of a particular Medical centre on this form
            //Filter the data based on the MedicalCentreNo passed as a parameter
            p15200790_tblMedicalCentreBindingSource.Filter = "abh_MedicalCentreNo = " + Convert.ToString(abh_MedicalCentreNo);
        }

        public void AddNewMedical()
        {
            //Public Add Method
            //Set the form in data entry mode
            p15200790_tblMedicalCentreBindingSource.AddNew();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //end the editing 
            this.p15200790_tblMedicalCentreBindingSource.EndEdit();
            this.p15200790_tblPracticeGPBindingSource.EndEdit();
            //Update the data to the database using the data adapter
            this.tableAdapterManager.UpdateAll(this.abdinasir_Hussein_ConsultantsDBDataSet);
        }

        private void p15200790_tblPracticeGPDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            {
              
            }
        }

       

    }

}
