using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADOWebApplication1
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string CS = "Data Source=127.0.0.1;  database=demodb;  user id=sa;  password=123abc;";
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString)) 
            {
                //SqlCommand cmd = new SqlCommand("select * from Employee1", con);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from Employee1";
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                con.Close();

                con.Open();
                cmd.CommandText = "select Count (PKEmpId) from Employee1";
                int Rows = (int)cmd.ExecuteScalar();
                Response.Write("<br><br>");
                Response.Write("Total Rows = " + Rows.ToString());
                //con.Close();
            }
        }
    }
}