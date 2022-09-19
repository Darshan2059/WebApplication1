using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        //Get : /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        //
        // Get: /HelloWorld/Welcome/
        //


        //Requires using System.Text.Encoding.Web;

        public IActionResult Welcome(string name, int numTimes)
        {
            ViewData["Message"] = "Hello " + name ;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
