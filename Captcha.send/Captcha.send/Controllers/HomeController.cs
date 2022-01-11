using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using Captcha.send.Models;
using CaptchaMvc.HtmlHelpers;

namespace Captcha.send.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string empty, Model model)
        {
     

            // Code for validating the CAPTCHA  
            if (this.IsCaptchaValid("Captcha is not valid"))
            {

                return RedirectToAction("About");
            }

            ViewBag.ErrMessage = "Error: captcha is not valid.";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }


    }
}