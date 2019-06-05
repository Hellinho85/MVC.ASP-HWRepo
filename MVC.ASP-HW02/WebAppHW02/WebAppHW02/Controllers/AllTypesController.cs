using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppHW02.Controllers
{
    public class AllTypesController : Controller
    {

        // View returns a view as a web page;
        public IActionResult ViewResult()
        {
            return View();
        }

        // PartialView returns the partial view of a web page;
        public IActionResult PartialViewResult()
        {
            return PartialView();
        }

        // EmptyResult returns an empty result (when we don't want to return anything);
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }

        // JsonResult return a result which contains a JSON string;
        public IActionResult JsonResult()
        {
            var json = new { FirstName = "Gjorgji", LastName = "Kongulovski",
                Age = 33, Academy = "SEDC Web Developement", Year = 2018 };
            return new JsonResult(json);
        }

        // ContentResult returns a user-defined content type;
        public IActionResult ContentResult(int StdId)
        {
            var students = new[]
            {
               new {StdId = 1, StdName = "Gjorgji", Age = 33},
               new {StdId = 2, StdName = "Riste", Age = 38},
               new {StdId = 3, StdName = "Toshka", Age = 37}
           };

            string matchStdName = null;
            foreach (var student in students)
            {
                if (student.StdId == StdId)
                {
                    matchStdName = student.StdName;
                }
            }

            return Content(matchStdName, "text/plain");
        }

        // FileResult returns a binary output to write to the response;
        public IActionResult FileResult(int EmpId)
        {
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName, "application/pdf");
        }

        // RedirectResult redirects us on the browser to another action;
        public IActionResult RedirectResult()
        {
            string eurUrl = "https://www.eurosport.com/";
            return Redirect(eurUrl);
        }
       
    }
}