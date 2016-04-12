using PracticeVelocityLib.Classes;
using System;
using WinFormPracticeVelocity.Global;
using System.Windows.Forms;

namespace WinFormPracticeVelocity
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            btnArry = new Button[] { btnAddOne, btnSubOne, btnLoopToMax };
            txtMessages.Text += Environment.NewLine;
        }

        #region "Public/Private Variables"

        public Register mainRegister;
        public Diagnose mainDiagnose;
        private Button[] btnArry;

        #endregion
       
        #region "Button Methods"

        private void btnCreateRegister_Click(object sender, EventArgs e)
        {
            if (mainRegister == null)
            {
                mainRegister = new Register();
                GlobalMethods.AddValToCombo("Register", cmbActive);
                GlobalMethods.AddMessageToTextbox("Register Create Successfully", txtMessages);
                GlobalMethods.SetLabelTextAndColor(lblRegisterStatus);
            }
            else
            {
                GlobalMethods.AddMessageToTextbox("Register is already created.", txtMessages);
            }

        }

        private void btnCreateDiagnosis_Click(object sender, EventArgs e)
        {
            if (mainDiagnose == null)
            {
                mainDiagnose = new Diagnose();
                GlobalMethods.AddValToCombo("Diagnose", cmbActive);
                GlobalMethods.AddMessageToTextbox("Diagnose Create Successfully", txtMessages);
                GlobalMethods.SetLabelTextAndColor(lblDiagnosisStatus);
            }
            else
            {
                GlobalMethods.AddMessageToTextbox("Diagnose is already created.", txtMessages);
            }
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if (cmbActive.Text == "Register" && mainRegister != null)
            {
                mainRegister.Add();
                GlobalMethods.AddMessageToTextbox(mainRegister.GetLastMessage(), txtMessages);
            }
            else if (cmbActive.Text == "Diagnose" && mainDiagnose != null)
            {
                mainDiagnose.Add();
                GlobalMethods.AddMessageToTextbox(mainDiagnose.GetLastMessage(), txtMessages);
            }
        }

        private void btnSubOne_Click(object sender, EventArgs e)
        {
            if (cmbActive.Text == "Register" && mainRegister != null)
            {
                mainRegister.Sub();
                GlobalMethods.AddMessageToTextbox(mainRegister.GetLastMessage(), txtMessages);
            }
            else if (cmbActive.Text == "Diagnose" && mainDiagnose != null)
            {
                mainDiagnose.Sub();
                GlobalMethods.AddMessageToTextbox(mainDiagnose.GetLastMessage(), txtMessages);
            }
        }

        private void btnLoopToMax_Click(object sender, EventArgs e)
        {
            if (cmbActive.Text == "Register" && mainRegister != null)
            {
                for (int i = mainRegister.GetCounter(); i < mainRegister.GetMaxVal(); i++)
                {
                    mainRegister.Add();
                    GlobalMethods.AddMessageToTextbox(mainRegister.GetLastMessage(), txtMessages);
                }
            }
            else if (cmbActive.Text == "Diagnose" && mainDiagnose != null)
            {
                for (int i = mainDiagnose.GetCounter(); i < mainDiagnose.GetMaxVal(); i++)
                {
                    mainDiagnose.Add();
                    GlobalMethods.AddMessageToTextbox(mainDiagnose.GetLastMessage(), txtMessages);
                }
            }
        }

        private void btnResetAll_MouseClick(object sender, MouseEventArgs e)
        {
            txtMessages.Text = "";
            txtMessages.Text += "Messages: " + Environment.NewLine;
        }

        #endregion

        #region "Other Methods"

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalMethods.SetButtonVis(cmbActive.Text, btnArry);
            string txtVal = cmbActive.Text;
            if (cmbActive.Text != "None")
            {
                btnAddOne.Text = "Add One To " + txtVal;
                btnSubOne.Text = "Subtract One From " + txtVal;
                btnLoopToMax.Text = "Loop To Max " + txtVal + " Value";
            }
        }

        #endregion
    }
}
