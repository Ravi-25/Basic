using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;


namespace RegForm
{
    public partial class Add1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["FName"] != null)
                {
                    TxtFName.Text = Session["FName"].ToString().Trim();
                    TxtLName.Text = Session["LName"].ToString().Trim();
                    TxtEmail.Text = Session["Email"].ToString().Trim();
                    BtnAdd.Enabled = false;
                    BtnSave.Enabled = true;
                }
                else
                {
                    BtnSave.Enabled = false;
                }
            }
            
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            BtnSave.Enabled = false;
            Lbl.Text = "";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sampleConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                string FName = "", LName = "", Email = "";
                FName = TxtFName.Text.Trim(); 
                LName = TxtLName.Text.Trim(); 
                Email = TxtEmail.Text.Trim(); 
                cmd.CommandText = "insert into person(FirstName, LastName, Email) values('" + FName +"','"+ LName +"','"+ Email +"')";
                cmd.Connection =con;
                con.Open();
                cmd.ExecuteNonQuery();
                Lbl.Text = " 1 Row Inserted Sucessfully";
                Lbl.ForeColor = System.Drawing.Color.Green;
                //ViewState["sortdr"] = "Asc";
            }
        }

            protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/DataGrid.aspx");
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            //BtnSave.Enabled = true;
            Lbl.Text = "";
            string selectedValue = Session["selectedval"].ToString();
            //TxtFName.Text = Session["FName"].ToString();
            //TxtLName.Text = Session["FName"].ToString();
            //TxtEmail.Text = Session["FName"].ToString();

            //lblMsg.Text = selectedValue;
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sampleConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                string FName = "", LName = "", Email = "";
                FName = TxtFName.Text.Trim();
                LName = TxtLName.Text.Trim();
                Email = TxtEmail.Text.Trim();
                cmd.CommandText = "update person set FirstName='" + FName + "', LastName='" +LName + "', Email='" + Email + "' where Email='"+ selectedValue +"'";
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                //ViewState["sortdr"] = "Asc";
                Lbl.Text = " 1 Row Updated Sucessfully";
                Lbl.ForeColor = System.Drawing.Color.Green;
            }
        }

        protected void Unload(object sender, EventArgs e)
        {
            TxtFName.Text = "";
            TxtLName.Text = "";
            TxtEmail.Text="";
            Session["FName"] = null;
            Session["LName"] = null;
            Session["FName"] = null;
        }
    }
}