using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/ 
        //The Index method uses a view template to generate an HTML response to the browser. 
        public ActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        //Now data is taken from the URL and passed to the controller using the model binder
        //The controller packages the data into a ViewBag object and passes that object to the view.
        //The view then displays the data as HTML to the user.
        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
        }
    }
}
