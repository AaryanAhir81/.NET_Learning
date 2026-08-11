using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Student_Form
{
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnNext1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void btnPrevious1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void btnNext2_Click(object sender, EventArgs e)
        {
            lblName.Text = txtName.Text;
            lblGender.Text = rblGender.SelectedItem.Text;
            lblAddress.Text = txtAddress.Text;
            lblDegree.Text = ddlDegree.SelectedItem.Text;
            lblEmail.Text = txtEmail.Text;
            lblContact.Text = txtContact.Text;

            MultiView1.ActiveViewIndex = 2;
        }

        protected void btnPrevious2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }
    }
}