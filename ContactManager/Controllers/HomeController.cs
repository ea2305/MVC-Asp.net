using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            var model = new List<Tweets>();
            var client = new HttpClient();
            //Respond massages
            var task =
                client.GetAsync("http://search.twitter.com/search.json?q=pluralsight")
                .ContinueWith((taskwithmsg) => {
                    var response = taskwithmsg.Result;
                    response.Content.ReadAsStringAsync<Json>();

                }
                );
            task.Wait();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}