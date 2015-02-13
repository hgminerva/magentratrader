﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MagentaTrader.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Admin/Event
        [Authorize]
        public ActionResult Event()
        {
            return View();
        }
	}
}