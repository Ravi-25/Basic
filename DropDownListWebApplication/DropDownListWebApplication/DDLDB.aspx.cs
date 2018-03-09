using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace DropDownListWebApplication
{
    public partial class DDLDB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            { 
              string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
              using (SqlConnection con = new SqlConnection(str))
              {
                    //SqlCommand cmd = new SqlCommand("select * from Employee1", con);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from Department";
                    cmd.Connection = con;
                    con.Open();
                    DropDownList2.DataSource = cmd.ExecuteReader();
                    DropDownList2.DataTextField = "Location";
                    DropDownList2.DataValueField = "PKDeptId";
                    DropDownList2.DataBind();
                    //con.Close();
                }
            }
        }
    }
}