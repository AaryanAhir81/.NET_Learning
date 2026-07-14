using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_Application_1
{
    public partial class First_Web_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (MALE_BTN.Checked)
            {
                Label2.Text = "MALE";
            }
            else if(FEMALE_BTN.Checked)
            {
                Label2.Text = "FEMALE";
            }
            else
            {
                Label2.Text = "Select an gender";

            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int Total = 0;
            if (C.Checked)
            {
                Total += 100;
                Label4.Text = "C";
            }
            else if (JAVA.Checked)
            {
                Total += 300;
                Label4.Text = "JAVA";
            }
            else if(C_SHARP.Checked)
            {
                Total += 500;
                Label4.Text = "C_SHARP";
            }
            else
            {
                Label3.Text = "...";
            }

            Label3.Text = "Price is: " + Total;
        }
    }
}