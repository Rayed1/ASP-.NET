﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ass1.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
       
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Index() 
        {
            return View();
        }
        public ActionResult Personal() 
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Projects()
        {
            return View();
        }
        public ActionResult Reference()
        {
            return View();
        }
        
    }
}