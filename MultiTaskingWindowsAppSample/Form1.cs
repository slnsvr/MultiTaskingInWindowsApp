using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace MultiTaskingWindowsAppSample
{
    public partial class Form1 : Form
    {
        Helper helper;

        public Form1()
        {
            InitializeComponent();

            HideGetControls();
            lblProcessing.Visible = false;
            helper = new Helper();
        }

        private void HideGetControls()
        {
            //just hiding the controls initially unti the get details are requested
            lblGetName.Visible = lblGetGender.Visible = lblGetID.Visible = lblGetAge.Visible = 
            txtGetName.Visible = txtGetGender.Visible = txtGetAge.Visible = txtGetID.Visible = false;
        }

        private void UnHideGetControls()
        {
            //just hiding the controls initially unti the get details are requested
            lblGetName.Visible = lblGetGender.Visible = lblGetID.Visible = lblGetAge.Visible =
            txtGetName.Visible = txtGetGender.Visible = txtGetAge.Visible = txtGetID.Visible = true;
        }

        private void ClearGetControls()
        {
            txtGetGender.Clear();
            txtGetName.Clear();
            txtGetAge.Clear();
            txtGetID.Clear();
        }

        private async void btnGetEmployeeDetails_Click(object sender, EventArgs e)
        {
            //just disabling the get button till the 4 actions are completed sequentially
            btnGetEmployeeDetails.Enabled = false;
            txtInputID.Enabled = false;
            ClearGetControls();

            bool found = helper.IsEmployeeFound(txtInputID.Text);             

            //if the ID is found, then only process, else skip the process
            if (found)
            {
                lblProcessing.Visible = true;                
                btnClear.Enabled = false;

                lblProcessing.Text = "Processing one by one detail.. please see below";
                UnHideGetControls();

                //Action1 running in the backgroud without blocking UI..
                //we are awaiting for this task to be done so that the next action steps will be done
                //in sequence after this is completed only..
                txtGetName.Text = await Task.Run(() => helper.GetName(txtInputID.Text));

                //Action2 running in the backgroud without blocking UI..
                //we are awaiting for this task to be done so that the next action steps will be done
                //in sequence after this is completed only..
                txtGetGender.Text = await Task.Run(() => helper.GetGender(txtInputID.Text.ToString()));


                //Action3 running in the backgroud without blocking UI..
                //we are awaiting for this task to be done so that the next action steps will be done
                //in sequence after this is completed only..
                txtGetAge.Text = Convert.ToString(await Task.Run(() => helper.GetAge(txtInputID.Text.ToString())));

                //Action4 running in the backgroud without blocking UI..
                //we are awaiting for this task to be done so that the next action steps will be done
                //in sequence after this is completed only..
                txtGetID.Text = Convert.ToString(await Task.Run(() => helper.GetID(txtInputID.Text.ToString())));

                //once the processing of the above 4 actions are completed
                lblProcessing.Text = string.Empty;
                lblProcessing.Visible = false;

                //allowing to clear the info that we got
                btnClear.Enabled = true;
            }
            else
            {
                lblProcessing.Text = "ID not found... Please try with a valid one";
                lblProcessing.Visible = true;
            }

            //enabling to allow the user to get another id info
            btnGetEmployeeDetails.Enabled = true;
            txtInputID.Enabled = true;
        }



        private void btnSaveEmployess_Click(object sender, EventArgs e)
        {
            helper.SaveEmployeeDetails(txtID.Text, txtName.Text, txtGender.Text, txtAge.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearGetControls();
        }        
    }
}
