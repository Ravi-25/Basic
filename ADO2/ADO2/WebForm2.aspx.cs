using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;


namespace ADO2
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spAddEmployees";//stored procedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;//command type
                cmd.Parameters.AddWithValue("@Name", txtEmployeeName.Text);
                cmd.Parameters.AddWithValue("@Gender", ddlGender.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary", txtSalary.Text);

                //output paramatr
                SqlParameter OutPar = new SqlParameter();
                OutPar.ParameterName = "@EmployeeId";
                OutPar.SqlDbType = System.Data.SqlDbType.Int;
                OutPar.Direction = System.Data.ParameterDirection.Output;

                //Binding it with cmd
                cmd.Parameters.Add(OutPar);

                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();

                string EmpId = OutPar.Value.ToString();
                lblMessage.Text ="Employee Id = "+ EmpId;

            }
        }
    }
}