using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DataReader
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select ProductId,ProductName,UnitPrice from tblProductInventory1", con);
     
                using (SqlDataReader Rdr = cmd.ExecuteReader())
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID");
                    table.Columns.Add("Name");
                    table.Columns.Add("Price");
                    table.Columns.Add("Discount Price");

                    while(Rdr.Read())
                    {
                        DataRow DR = table.NewRow();

                        int price = Convert.ToInt32(Rdr["UnitPrice"]);
                        double DisPrice = price * .90;

                        DR["ID"] = Rdr["ProductId"];
                        DR["Name"] = Rdr["ProductName"];
                        DR["Price"] = price;// Rdr["UnitPrice"];
                        DR["Discount Price"] = DisPrice;

                        table.Rows.Add(DR);


                        GridView1.DataSource = table;
                        GridView1.DataBind();

                    }
                }

            }
        }
    }
}