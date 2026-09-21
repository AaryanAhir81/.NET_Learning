using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace RegisterDemo
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\R.K Univesrsity\\Sem-5\\.NET_Learning\\02_ASP.NET\\RegisterDemo\\App_Data\\RegisterDB.mdf\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            //con.Open();
            string query = "INSERT INTO Table Values('"+Name+"','"+Email+"','"+txtPassword+"')";
            SqlCommand cmd = new SqlCommand(query,con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('Registered Successfully');</script>");
            con.Close();
        }
    }
}