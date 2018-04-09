using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace ADO2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // string CS = "Data Source=127.0.0.1;  database=demodb;  user id=sa;  password=123abc;";
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
           using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("select * from Employee1", con);
                //SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from tblProductInventory ";
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                
                //con.Close();

                //con.Open();
                //cmd.CommandText = "select Count (PKEmpId) from Employee1";
                //int Rows = (int)cmd.ExecuteScalar();
                //Response.Write("<br><br>");
                //Response.Write("Total Rows = " + Rows.ToString());
                //con.Close();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string CS = "Data Source=127.0.0.1;  database=demodb;  user id=sa;  password=123abc;";
            //string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                //SqlCommand cmd = new SqlCommand("select * from Employee1", con);
                SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "Select * from tblProductInventory where ProductName like '" + TextBox1.Text +"%'";
                //cmd.CommandText = "Select * from tblProductInventory where ProductName like @ProductName";  // using a paramater
                
                //cmd.CommandText = txt;
                //cmd.CommandText = "select * from tblProductInventory where ProductName like 'i%'";
                cmd.CommandText = "spGetPoductByName";//stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//command type
                cmd.Parameters.AddWithValue("@ProductName", TextBox1.Text + "%");
                cmd.Connection = con;
                con.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
                //GridView1.Visible = true;
                //con.Close();

                //con.Open();
                //cmd.CommandText = "select Count (PKEmpId) from Employee1";
                //int Rows = (int)cmd.ExecuteScalar();
                //Response.Write("<br><br>");
                //Response.Write("Total Rows = " + Rows.ToString());
                //con.Close();
            }
        }
    }
}