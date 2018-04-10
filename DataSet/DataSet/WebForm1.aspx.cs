using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataSet1
{
    public partial class WebForm11 : System.Web.UI.Page
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
                SqlDataAdapter da = new SqlDataAdapter("spGetData", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                DataSet Ds = new DataSet();
                da.Fill(Ds);
                Ds.Tables[0].TableName = "tblProductInventory";
                Ds.Tables[1].TableName = "tblProductInventory1";

                GridView1.DataSource = Ds.Tables["tblProductInventory"];// Ds.Tables[0];
                GridView1.DataBind();

                GridView2.DataSource = Ds.Tables["tblProductInventory1"]; // Ds.Tables[1];
                GridView2.DataBind();



            }
        }
    }
}