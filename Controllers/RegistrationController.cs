using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using RegistrationPage.Models;
namespace RegistrationPage.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Index()
        {

            SqlConnection connection = new SqlConnection("server=.;database=PracticeDB;integrated security=SSPI");
            SqlCommand command = new SqlCommand("select [id],[name],[email] from student1", connection);
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<Student1Model> list = new List<Student1Model>();

            while(reader.Read())
            {
                list.Add(new Student1Model
                {
                    id=reader.GetInt32(0),
                    name =reader.GetString(1),
                    email=reader.GetString(2)
                });

            }
            reader.Close();
            connection.Close();
            ViewBag.data = list;
            return View();
        }
    }
}