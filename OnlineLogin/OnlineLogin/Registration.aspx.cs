using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace OnlineLogin
{
    public partial class Regristration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSub_Click(object sender, EventArgs e)
        {
            //string EncryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TxtPwd.Text.Trim(), "SHA1");

            if (Page.IsValid)
            {
                // Read the connection string from web.config.
                // ConfigurationManager class is in System.Configuration namespace
                //string cs=ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
                string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection con = new SqlConnection(CS))
                {
                    SqlCommand cmd = new SqlCommand("spRegisterUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter username = new SqlParameter("@UserName", TxtUName.Text);
                    // FormsAuthentication calss is in System.Web.Security namespace
                    string encryptedPassword = FormsAuthentication.HashPasswordForStoringInConfigFile(TxtPwd.Text, "SHA1");
                    SqlParameter password = new SqlParameter("@Password", encryptedPassword);
                    SqlParameter email = new SqlParameter("@Email", TxtEmail.Text);

                    cmd.Parameters.Add(username);
                    cmd.Parameters.Add(password);
                    cmd.Parameters.Add(email);
                    

                    con.Open();
                    int ReturnCode = (int)cmd.ExecuteScalar();
                    if (ReturnCode == -1)
                    {
                        lblMessage.Text = "User Name already in use, please choose another user name";
                    }
                    else
                    {
                        Session["Uname"] = TxtUName.Text;
                        Response.Redirect("~/Sucess.aspx");
                    }
                }
            }
        }

        protected void BtnReset_Click(object sender, EventArgs e)
        {

            //txtuname.text = "";
            //txtpwd.text = "";
            //txtpwd2.text = "";
            //txtemail.text = "";
            //lblmessage.text = "";
        }
    }
}