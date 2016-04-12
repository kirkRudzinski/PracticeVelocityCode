using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WinFormPracticeVelocity.Global
{
    public static class GlobalMethods
    {
        public static void SetButtonVis(string msg, Button[] btns)
        {
            bool canUse = (msg != null) ? msg != "" : false;
            if (canUse? btns != null : false)
            {                
                for (int i = 0; i < btns.Count(); i++)
                {
                    if (msg == "None")
                        btns[i].Visible = false;
                    else
                        btns[i].Visible = true;
                }                
            }

        }
        public static void AddValToCombo(string val, ComboBox cmb)
        {
            bool canUse = (val != null) ? val.Trim() != "" : false;
            if (canUse ? cmb.Items.Contains(val) == false : false)
                cmb.Items.Add(val);
        }

        public static void AddMessageToTextbox(string msg, TextBox txt)
        {
            bool canUse = (msg != null) ? msg.Trim() != "" : false;
            if (canUse)
                txt.Text += msg.Trim() + Environment.NewLine;
        }

        public static void SetLabelTextAndColor(Label lbl)
        {
            if (lbl.Text != "ACTIVE")
            {
                lbl.Text = "ACTIVE";
                lbl.ForeColor = Color.Green;
            }
            else
            {
                lbl.Text = "EMPTY";
                lbl.ForeColor = Color.Black;
            }
        }

    }
}
