using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataSetCache
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Cache["data"] == null)
            {
                string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(cs))
                {
                    //con.Open();
                    //SqlCommand cmd = new SqlCommand("Select* from tblProductInventory1;", con);

                    SqlDataAdapter da = new SqlDataAdapter("Select* from tblProductInventory1;", con);

                    //for Stored Procedure
                    //SqlDataAdapter da = new SqlDataAdapter("spGettblProductInventory1", con);
                    //da.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataSet Ds = new DataSet();
                    da.Fill(Ds);

                    Cache["data"] = Ds;


                    GridView1.DataSource = Ds;  
                    GridView1.DataBind();

                    Label1.Text = "Data Loaded From DB";



                }
            }
            else
            {
                GridView1.DataSource = (DataSet)Cache["data"];
                GridView1.DataBind();
                Label1.Text = "Data Loaded From Cache";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(Cache["data"]!=null)
            {
                Cache.Remove("data");
                Label1.Text = "DataSet cleared from Cache ";
            }
            else
            {
                Label1.Text = "Cache already Cleared";
            }
        }
    }
}