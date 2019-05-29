using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_Empty.Controllers
{
    public class HomeController : Controller
    {
        public string GetGreetings()
        {
            return "The World is Yours!!!";
        }
    }
}