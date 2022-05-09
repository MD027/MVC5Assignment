﻿using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["str1"] = "This is a String passed using viewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
            return View();
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult SaveUser(User u)
        {
            StreamWriter sw = new StreamWriter(Server.MapPath("~/App_Data/users.txt"), true);
            sw.WriteLine("User details added on : " + DateTime.Now.ToString());
            sw.WriteLine("User Name : " + u.UserName);
            sw.WriteLine("Password : " + u.Password);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been Saved!!");
        }

        //just for demonstration HtmlHelpers
        public ActionResult HtmlHelpers()
        {
            return View();
        }




    }
}