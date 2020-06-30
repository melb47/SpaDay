using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        static private List<User> Users = new List<User>();
        public IActionResult Index()
        {
            ViewBag.users = Users;
            return View();
        }
        
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if(newUser.Password == verify)
            {
                ViewBag.user = newUser;
                //Users.Add(newUser);
                return View("Index");
            }
            else
            {
                return View("Add");
            }
        }
    }
}
