﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace PandeyBooks.Controllers.Web
{
    public class StoreController : Controller
    {
        // GET: /<controller>/
        // GET: /Store/
        public string Index()
        {
            return "Hello from Store.Index()";
        }
        // GET: /Store/Browse
        public string Browse()
        {
            return "Hello from Store.Browse()";
        }
        // GET: /Store/Details
        public string Details()
        {
            return "Hello from Store.Details()";
        }
    }

}
