using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataReader
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select* from tblProductInventory1;Select* from tblProductInventory", con);

                using (SqlDataReader Rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = Rdr;
                    GridView1.DataBind();

                    while (Rdr.NextResult())
                    {
                        GridView2.DataSource =Rdr;
                        GridView2.DataBind();

                    }
                }

            }
        }
    }
    
}