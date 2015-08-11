using MyFirstWebsite.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstWebsite.Controllers
{
    public class StuffController : Controller
    {
        //
        // GET: /Stuff/

        //By adding a parameter called "name" ASP.NET MVC will automatically 
        //try to match it to something in the url.
        //So it will automatically be set to the value in the url that corresponds
        //to the "name" parameter we created in the RouteConfig file.

        //[Authorize]
        [Log]
        public ActionResult Search(string name = "unicorn") //"unicorn" is Default value
        {
            //Used to format incoming data from the url to pure html
            //so as to prevent xss attacks.
            var message = Server.HtmlEncode(name);

            return Content(message);
        }
    }
}
