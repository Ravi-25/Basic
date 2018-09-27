using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace OnlineLogin
{
    public partial class Authorisation1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Uname"] != null)
            {

                Master.Li.Visible = false;
                Master.Lo.Visible = true;
                if(Session["UType"].ToString()=="Administrator")
                {
                    Master.Aut.Visible = true;
                }
                else
                {
                    Response.Redirect("~/NotAut.aspx");
                }
            }
            else
            {
                Response.Redirect("~/Master.aspx");
            }
            if (!IsPostBack)
            {
                string str = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(str))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from tbluser";
                    cmd.Connection = con;
                    con.Open();
                    DdlUser.DataSource = cmd.ExecuteReader();
                    DdlUser.DataTextField = "UName";
                    //DdlUser.DataValueField = "UName";
                    DdlUser.DataBind();
                    con.Close();

                    DdlUser.Items.Insert(0, "Select One");
                    DdlUser.SelectedIndex = 0;

                    cmd.CommandText = "select * from tblUType";
                    cmd.Connection = con;
                    con.Open();
                    DdlType.DataSource = cmd.ExecuteReader();
                    DdlType.DataTextField = "UType";
                    DdlType.DataValueField = "UTypeId";
                    DdlType.DataBind();
                    con.Close();

                    DdlType.Items.Insert(0, "Select One");
                    DdlType.SelectedIndex = 0;
                }
                DdlType.Enabled = false;
                BtnSave.Enabled = false;
            }
        }

        protected void DdlUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblUName.Text = DdlUser.SelectedItem.Text.ToString();
            if ((DdlUser.SelectedItem.Text.ToString()) != "Select One")
            {
                BtnSave.Enabled = true;
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spSelected", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter username = new SqlParameter("@UserName", DdlUser.SelectedItem.Text.ToString());

                    cmd.Parameters.Add(username);
                    //Add the output parameter to the command object
                    SqlParameter outPutParameter = new SqlParameter("@UType", "");
                    ///outPutParameter.ParameterName = "@UType";
                    outPutParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    outPutParameter.Direction = System.Data.ParameterDirection.Output;
                    outPutParameter.Size = 50;
                    cmd.Parameters.Add(outPutParameter);

                    con.Open();

                    cmd.ExecuteScalar();
                    String UType = outPutParameter.Value.ToString();

                    DdlType.SelectedIndex = DdlType.Items.IndexOf(DdlType.Items.FindByText(UType));
                    LblUtype.Text = UType;
                    if (UType == "null") { BtnSave.Enabled = false; }
                }
            }
            else
            {
                BtnSave.Enabled = false;
                LblUName.Text = "null";
            }
        }

        protected void DdlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblUtype.Text = DdlType.SelectedItem.Text.ToString();
            if ((DdlType.SelectedItem.Text.ToString()) == "Select One" || (DdlType.Text.ToString()) == "Select One")
            {
                BtnSave.Enabled = false;
                LblUtype.Text = "null";
            }
            else { BtnSave.Enabled = true; }
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            DdlType.Enabled = true;
            //BtnEdit.Enabled = false;
            if ((DdlType.Text.ToString()) == "Select One" || (DdlType.Text.ToString()) == "Select One")
            {
                BtnSave.Enabled = false;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (((DdlUser.SelectedItem.Text.ToString()) != "Select One") && ((DdlType.SelectedItem.Text.ToString()) != "Select One"))
            {
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spSave", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter username = new SqlParameter("@UserName", DdlUser.SelectedItem.Text.ToString());
                    SqlParameter usertypee = new SqlParameter("@UType", DdlType.SelectedItem.Text.ToString());

                    cmd.Parameters.Add(username);
                    cmd.Parameters.Add(usertypee);

                    //Add the output parameter to the command object
                    //SqlParameter outPutParameter = new SqlParameter("@UType", "");
                    ///outPutParameter.ParameterName = "@UType";
                    //outPutParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    //outPutParameter.Direction = System.Data.ParameterDirection.Output;
                    //outPutParameter.Size = 50;
                    //cmd.Parameters.Add(outPutParameter);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    DdlType.Enabled = false;
                    BtnSave.Enabled = false;
                }
            }
        }

    }
}