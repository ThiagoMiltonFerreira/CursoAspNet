﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Introducao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index() // Todo metodo de retorno de uma view tem que ser do tipo ActionResult 
        {
            return View();
        }

    }
}