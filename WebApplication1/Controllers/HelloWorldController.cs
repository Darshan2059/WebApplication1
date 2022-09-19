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

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");
        }
    }
}
