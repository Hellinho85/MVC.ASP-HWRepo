using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppHW01_WebForms.Controllers
{
    public class HomeController : Controller
    {
       public string GetGreetings()
        {
            return "The World is Yours!!!";
        }
    }
}