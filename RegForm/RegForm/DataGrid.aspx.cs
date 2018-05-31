using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using CrystalDecisions.CrystalReports.Engine;

namespace RegForm
{
    public partial class DataGrid : System.Web.UI.Page
    {
        //PersonDataAccessLayer per = new PersonDataAccessLayer();
        public string NotSelected = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["senderRd"] != null)
            //{
            //    object senderRd = Session["senderRd"];
            //    RadioButton rb = (RadioButton)senderRd;
            //    GridViewRow row = (GridViewRow)rb.NamingContainer;
            //    ((RadioButton)row.FindControl("MyRadioButton")).Checked = true;
            //}
            if (!IsPostBack)
            {
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sampleConnectionString"].ConnectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select * from person ";
                    cmd.Connection = con;
                    con.Open();
                    PersonGrid.DataSource = cmd.ExecuteReader();
                    PersonGrid.DataBind();
                    //ViewState["sortdr"] = "Asc";
                }
            }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Add.aspx");
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            //string selectedValue = Request.Form["MyRadioButton"];
            //Session["selectedval"] = selectedValue;
            Lbl.Text = "";

            string FName="", LName="", Email="";

            for (int i = 0; i < PersonGrid.Rows.Count; i++)
            {
                RadioButton rb = (PersonGrid.Rows[i].FindControl("MyRadioButton") as RadioButton);
                if (rb.Checked==true)
                {
                    FName = PersonGrid.Rows[i].Cells[1].Text.Trim();
                    LName = PersonGrid.Rows[i].Cells[2].Text.Trim();
                    Email = PersonGrid.Rows[i].Cells[3].Text.Trim();
                }
            }
            if (FName != "")
            {
                Session["FName"] = FName.Trim(); 
                Session["LName"] = LName.Trim();
                Session["Email"] = Email.Trim();
                Session["selectedval"] = Email.Trim();

                Response.Redirect("~/Add.aspx");
            }
            else
            {
                Lbl.Text = "Selecct a Row to Edit";
                Lbl.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void BtnDel_Click(object sender, EventArgs e)
        {
            Lbl.Text = "";
            string selectedValue = "";
            for (int i = 0; i < PersonGrid.Rows.Count; i++)
            {
                RadioButton rb = (PersonGrid.Rows[i].FindControl("MyRadioButton") as RadioButton);
                if (rb.Checked == true)
                {
                    //FName = PersonGrid.Rows[i].Cells[1].Text;
                    //LName = PersonGrid.Rows[i].Cells[2].Text;
                    selectedValue = PersonGrid.Rows[i].Cells[3].Text.Trim();
                }
            }
            //string selectedValue = Request.Form["MyRadioButton"];
            if (selectedValue != "")
            {

                //if ((System.Windows.Forms.DialogResult.Yes) == (System.Windows.Forms.MessageBox.Show("Are you sure , you want to Delete the Row", "Delete", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question)))
                {
                    using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sampleConnectionString"].ConnectionString))
                    {
                        SqlCommand cmd = new SqlCommand();
                        cmd.CommandText = "delete from person where Email='" + selectedValue + "'";
                        cmd.Connection = con;
                        con.Open();
                        cmd.ExecuteNonQuery();
                        //PersonGrid.DataBind();

                        Lbl.Text = " 1 Row Deleted Sucessfully";
                        Lbl.ForeColor = System.Drawing.Color.Green;
                        cmd.CommandText = "select * from person";
                        PersonGrid.DataSource = cmd.ExecuteReader();
                        PersonGrid.DataBind();
                    }
                }
            }
            else
            {
                Lbl.Text = "Select a Row to Delete";
                Lbl.ForeColor = System.Drawing.Color.Red;
            }
        }
       

        protected void PersonGrid_Sorting(object sender, GridViewSortEventArgs e)
        {
            Lbl.Text = "";
            String columnName = e.SortExpression.ToString();
            string order = "";

            if(Session["sortexp"]==null )
            {
                Session["sortexp"] = columnName;
                order = " Asc";
            }
            else if(Session["sortexp"].ToString()==columnName)
            {
                Session["sortexp"] = null;
                order = " Desc";
            }
            else 
            {
                Session["sortexp"] = columnName;
                order = " Asc";
            }
            
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["sampleConnectionString"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select * from person order by " + columnName + order;
                cmd.Connection = con;
                con.Open();
                PersonGrid.DataSource = cmd.ExecuteReader();
                PersonGrid.DataBind();
            }

            //if (Session["senderRd"] != null)
            //{
            //    object senderRd = Session["senderRd"];
            //    RadioButton rb = (RadioButton)senderRd;
            //    GridViewRow row = (GridViewRow)rb.NamingContainer;
            //    ((RadioButton)row.FindControl("MyRadioButton")).Checked = true;
            //}
        }

        //protected void PersonGrid_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}


        protected void MyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the existing selected row 
            foreach (GridViewRow oldrow in PersonGrid.Rows)
            {
                ((RadioButton)oldrow.FindControl("MyRadioButton")).Checked = false;
            }

            Session["senderRd"] = sender;
           
            //Set the new selected row
            RadioButton rb = (RadioButton)sender;
            GridViewRow row = (GridViewRow)rb.NamingContainer;
            ((RadioButton)row.FindControl("MyRadioButton")).Checked = true;

            ScriptManager.RegisterStartupScript(this.Page, Page.GetType(), "text", "MyRadioButton_CheckedChanged()", true);
        }
    }
} 