using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAdapter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                //con.Open();
                //SqlCommand cmd = new SqlCommand("Select* from tblProductInventory1;", con);

                //SqlDataAdapter da = new SqlDataAdapter("Select* from tblProductInventory1;", con);

                //for Stored Procedure
                SqlDataAdapter da = new SqlDataAdapter("spGettblProductInventory1", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet Ds = new DataSet();
                da.Fill(Ds);

                GridView1.DataSource = Ds;
                GridView1.DataBind();



            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                // SqlDataAdapter da = new SqlDataAdapter("spGettblProductInventory1ById", con);

                /*  OR  */

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand("spGettblProductInventory1ById", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@ProductId", TextBox1.Text);

                DataSet Ds = new DataSet();
                da.Fill(Ds);

                GridView1.DataSource = Ds;
                GridView1.DataBind();

            }
        }
    }
}