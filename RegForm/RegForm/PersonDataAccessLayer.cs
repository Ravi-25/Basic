//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Data;
//using System.Data.SqlClient;
//using System.Configuration;

//namespace RegForm
//{
//    public class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public string Email { get; set; }
//    }
//    public class PersonDataAccessLayer
//    {
//        public static List<Person> GetAllPersons(string SortColumn)
//        {
//            List<Person> listperson = new List<Person>();

//            string CS = ConfigurationManager.ConnectionStrings["sampleConnectionString"].ConnectionString;
//            using (SqlConnection con = new SqlConnection(CS))
//            {
//                SqlCommand cmd = new SqlCommand("Select * from person", con);

//                con.Open();
//                SqlDataReader rdr = cmd.ExecuteReader();
//                while (rdr.Read())
//                {
//                    Person person= new Person();

//                    person.FirstName = rdr["FirstName"].ToString();
//                    person.LastName = rdr["LatName"].ToString();
//                    person.Email = rdr["Email"].ToString();

//                    listperson.Add(person);
//                }
//            }

//            return listperson;
//        }
//    }
//}