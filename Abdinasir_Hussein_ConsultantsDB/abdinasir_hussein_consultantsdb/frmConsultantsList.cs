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
    public partial class frmConsultantsList : Form
    {
        public frmConsultantsList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblMedicalCentre' table. You can move, or remove it, as needed.
            this.p15200790_tblMedicalCentreTableAdapter.Fill(this.abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblMedicalCentre);
            //disable the edit button
            btnEdit.Enabled = false;
            //disable the delete button
            btnDelete.Enabled = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Close();
        }

        private void lstBoxes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable the edit button
            btnEdit.Enabled = true;
            //enable the delete button
            btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create an instance of frmConsultantsEntry
            frmConsultantsEntry Medical = new frmConsultantsEntry();
            //make the form a child of the mdi parent
            Medical.MdiParent = this.MdiParent;
            //display the Medical entry form
            Medical.Show();
            //invoke the AddNewMedical method (that we create in frmConsultantsEntry)
            Medical.AddNewMedical();//Sets form ready for new Medical entry
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Create an instance of frmConsultantEntry
            frmConsultantsEntry Consultant = new frmConsultantsEntry();
            //declare a variable to store the abhMedicalCentreNo from the list box
            int abh_MedicalCentreNo;
            //check to see if a record has been selected
            if (lstBoxes.SelectedIndex !=-1)
            {
                //get the selected value from the list which should contain the primary key
                abh_MedicalCentreNo = Convert.ToInt32(lstBoxes.SelectedValue);
                //make the form a child of mdi parent
                Consultant.MdiParent = this.MdiParent;
                //display the Consultants entry form
                Consultant.Show();
                //invoke the findCentre method (that we created in frmConsultantEntry)
                Consultant.FindCentre(abh_MedicalCentreNo);//Filters form for this MedicalCentreNo
            }

            else
            {
                //if nothing is selected on the list then display a message
                MessageBox.Show("Please select a medical centre form the list", "abh_MedicalCentreNo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
              //declare a variable to store the result returned by the message 
            DialogResult Response;
            //ask the user if they really mean it
            Response = MessageBox.Show("Are you sure you want to delete the Medical centre", "Delete Medical Centre",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Response == DialogResult.Yes)
            {

                //declare a variable to store the index of the item on the list
                int Index;
                //get the index from the list box
                Index = lstBoxes.SelectedIndex;
                //delete the record
                abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblMedicalCentre.Rows[Index].Delete();
                //update the data to the database using the data adapter
                this.p15200790_tblMedicalCentreTableAdapter.Update(this.abdinasir_Hussein_ConsultantsDBDataSet);
                //refresh the list by calling the activated event handler
                this.frmConsultantsList_Activated(null, null);
            }
        }

        private void frmConsultantsList_Activated(object sender, EventArgs e)
        {
            //load the data from the order table
            this.p15200790_tblMedicalCentreTableAdapter.Fill(this.abdinasir_Hussein_ConsultantsDBDataSet.p15200790_tblMedicalCentre);
            //disable the edit button 
            btnEdit.Enabled = false;
            //disable the delete button
            btnDelete.Enabled = false;
        }
    }
}
