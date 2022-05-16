using Adresbook.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Adresbook.Controllers

{
 
    public class HomeController : Controller
    {
        UserContext db;
        public HomeController(UserContext context)
        {
            db = context;
        }
  
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Show(string search)
        { 
            var users = from m in db.Users
                         select m;

            if (!String.IsNullOrEmpty(search))
            {
                users = users.Where(s => s.Name.Contains(search));
            }
            {
                return View(users);
            }
        }
        [Authorize(Roles = "admin")]
        public IActionResult Edit()
        {
            return View(db.Users.ToList());
        }
        [HttpPost]
        public ActionResult AddUser()
        {
            string nameString = Request.Form.FirstOrDefault(p => p.Key == "name").Value;
            string emailString = Request.Form.FirstOrDefault(p => p.Key == "email").Value;
            string phoneString = Request.Form.FirstOrDefault(p => p.Key == "phone").Value;
            string BirhdayString = Request.Form.FirstOrDefault(p => p.Key == "birhday").Value;

            DateTime BirhdayS = DateTime.Parse(BirhdayString);

            if (phoneString == null || phoneString == "")
            {
                phoneString = "/-/";
            }

            db.AddRange(
                    new User
                    {
                        Name = nameString,

                        Email = emailString,
                        Birhday = BirhdayS,
                        Phone = phoneString
                    }
                    );
            db.SaveChanges();
            return RedirectToAction("Edit");
        }
        public ActionResult EditUser()
        {
            string nameString = Request.Form.FirstOrDefault(p => p.Key == "name").Value;
            string emailString = Request.Form.FirstOrDefault(p => p.Key == "email").Value;
            string phoneString = Request.Form.FirstOrDefault(p => p.Key == "phone").Value;
            string BirhdayString = Request.Form.FirstOrDefault(p => p.Key == "birhday").Value;

            string ID = Request.Form.FirstOrDefault(p => p.Key == "id").Value;
            DateTime BirhdayS = DateTime.Parse(BirhdayString);
            int num = Convert.ToInt32(ID);

            User q = db.Users.Where(o => o.Id == num).FirstOrDefault();

            q.Name = nameString;
            q.Email = emailString;
            q.Phone = phoneString;
            q.Birhday = BirhdayS;

            db.SaveChanges();
            return RedirectToAction("Edit");
        }
        public ActionResult DeleteUser()
        {
            string ID = Request.Form.FirstOrDefault(p => p.Key == "id").Value;
            int num = Convert.ToInt32(ID);

            User q = db.Users.Where(o => o.Id == num).FirstOrDefault();

            db.Users.Remove(q);
             db.SaveChanges();

            return RedirectToAction("Edit");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
