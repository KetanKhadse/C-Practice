using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;
using CrudWithoutEntity.Models;

namespace CrudWithoutEntity.Controllers
{
    public class UserRagistrationController : Controller
    {
        string connectionstring = @"Data Source=DESKTOP-EAERF90;Initial Catalog=CoreDemo;Integrated Security=true;TrustServerCertificate=True;MultipleActiveResultSets=true";
        // GET: UserRagistrationController
        public ActionResult Index()
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Select * From UserRagistration";
                SqlDataAdapter sda = new SqlDataAdapter(query,con);
                sda.Fill(dt);  


            }
            return View(dt);
        }


        // GET: UserRagistrationController/Create
        public ActionResult Create()
        {
            return View(new UserClass());
        }

        // POST: UserRagistrationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserClass user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "Insert Into UserRagistration Values(@FirstName,@LastName,@Email,@Password,@IsActive)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                    cmd.ExecuteNonQuery();


                }

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex) {
            
                
            }
                return View();
            }

        // GET: UserRagistrationController/Edit/5
        public ActionResult Edit(int id)
        {
            UserClass user = new UserClass();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Select * From UserRagistration where Id = @Id ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Id",id);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    user.Id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    user.FirstName = dt.Rows[0][1].ToString();
                    user.LastName = dt.Rows[0][2].ToString();
                    user.Email = dt.Rows[0][3].ToString();
                    user.Password = dt.Rows[0][4].ToString();
                    user.IsActive =Convert.ToInt32( dt.Rows[0][5].ToString());
                    return View(user);
                }
                

            }
            return RedirectToAction("Index");
        }

        // POST: UserRagistrationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserClass user)
        {
            try
            {
                
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "Update UserRagistration set FirstName=@FirstName,LastName=@LastName,Email=@Email,Password=@Password,IsActive=@IsActive Where Id = @Id ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@IsActive", user.IsActive);
                    cmd.ExecuteNonQuery();


                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserRagistrationController/Delete/5
        public ActionResult Delete(int id)
        {
            UserClass user = new UserClass();
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                con.Open();
                string query = "Select * From UserRagistration where Id = @Id ";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@Id", id);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    user.Id = Convert.ToInt32(dt.Rows[0][0].ToString());
                    user.FirstName = dt.Rows[0][1].ToString();
                    user.LastName = dt.Rows[0][2].ToString();
                    user.Email = dt.Rows[0][3].ToString();
                    user.Password = dt.Rows[0][4].ToString();
                    user.IsActive = Convert.ToInt32(dt.Rows[0][5].ToString());
                    return View(user);
                }


            }
            return RedirectToAction("Index");
        }

        // POST: UserRagistrationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, UserClass user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionstring))
                {
                    con.Open();
                    string query = "Delete From UserRagistration Where Id = @Id ";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", user.Id);
                    cmd.ExecuteNonQuery();


                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex) 
            {
                
            }
            return RedirectToAction("Index");
        }
    }
}
