﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_DataExploration.Models;

namespace MVC_DataExploration.Controllers
{
    public class ProductController : Controller
    {

        //private MyDbContext db = new MyDbContext();
        // GET: Product
        private MyDBContext db = new MyDBContext();

        public ActionResult Index()
        {
            return View(db.Products);
        }
    }
}