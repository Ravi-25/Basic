using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Security;
using System.Data;

namespace OnlineLogin
{
    public partial class Master1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Uname"] != null)
                {
                    TxtUname.Text = Session["Uname"].ToString();
                    //Master.FindControl("Ul").Visible = false;
                }
            }
        }

        protected void Page_Init(object Sender, EventArgs e)
        {
            if (Session["Uname"] == null)
            {
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetExpires(DateTime.Now.AddSeconds(-1));
                Response.Cache.SetNoStore();
            }
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            TxtUname.Text = "";
            TxtPwd.Text = "";
        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            if(TxtUname.Text=="" || TxtPwd.Text=="")
            {
                Lbl.Text = "Please enter both User Name and Password";
            }
           else  if (AuthenticateUser(TxtUname.Text, TxtPwd.Text))
            {
                Session["Uname"] = TxtUname.Text;
                FormsAuthentication.RedirectFromLoginPage(TxtUname.Text, true);
            }
            else
            {
                Lbl.Text = "Invalid User Name and/or Password";
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // ConfigurationManager class is in System.Configuration namespace
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            // SqlConnection is in System.Data.SqlClient namespace
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand cmd = new SqlCommand("sp_AutUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // FormsAuthentication is in System.Web.Security
                string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(password, "SHA1");
                // SqlParameter is in System.Data namespace
                SqlParameter paramUsername = new SqlParameter("@UName", username);
                SqlParameter paramPassword = new SqlParameter("@Password", EncryptedPassword);

                cmd.Parameters.Add(paramUsername);
                cmd.Parameters.Add(paramPassword);

                con.Open();
                int ReturnCode = (int)cmd.ExecuteScalar();

                con.Close();

                if (ReturnCode == 1)
                {
                    //con.Open();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandText = "spUType";
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.Connection = con;

                    SqlParameter usrname = new SqlParameter("@UserName", TxtUname.Text);

                    cmd1.Parameters.Add(usrname);
                    //Add the output parameter to the command object
                    SqlParameter outPutParameter = new SqlParameter("@UType", "");
                    ///outPutParameter.ParameterName = "@UType";
                    outPutParameter.SqlDbType = System.Data.SqlDbType.NVarChar;
                    outPutParameter.Direction = System.Data.ParameterDirection.Output;
                    outPutParameter.Size = 50;
                    cmd1.Parameters.Add(outPutParameter);

                    con.Open();

                    cmd1.ExecuteScalar();
                    String UType = outPutParameter.Value.ToString();
                    Session["UType"] = UType;
                }
                return ReturnCode == 1;
            }
        }
    }
}