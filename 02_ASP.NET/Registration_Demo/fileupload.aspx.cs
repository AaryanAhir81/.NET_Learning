using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Demo
{
    public partial class fileupload : System.Web.UI.Page
    {
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string folder = Server.MapPath("~/images/");

                // Create Uploads folder if it doesn't exist
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                string filename = Path.GetFileName(FileUpload1.FileName);

                FileUpload1.SaveAs(folder + filename);

                Label1.Text = "File Uploaded Successfully!";
            }
            else
            {
                Label1.Text = "Please select a file.";
            }
        }
    }
}