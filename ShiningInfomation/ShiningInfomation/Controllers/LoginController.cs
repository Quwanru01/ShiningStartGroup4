﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShiningInfomation.Models;
using ShiningInfomation.Models.ViewModel;

namespace ShiningInfomation.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Vm001 model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var userinfo = LoginDemo.LogFunction(model);
                    if (userinfo != null)
                    {
                        RedirectToAction("Index");
                        
                    }
                }

            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
            return View("Error");
        }
    }
}