using System.Linq;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            if (id is null)
                return View("Error");
            ViewData["Identity"] = id;
            return View("Index");
        }

        public ActionResult ChercheClient(string id)
        {
            var clients = new Clients();
            var client = clients.ObtenirClients().FirstOrDefault(c => c.Nom == id);
            ViewData["ClientTrouve"] = client;
            ViewData["Nom"] = id;
            return View(client != null ? "ChercheClient" : "NotFound");
        }

        public ActionResult ListeClients()
        {
            var clients = new Clients();
            ViewData["clients"] = clients.ObtenirClients();
            return View();
        }

        

        //public string HtmlEnString(string id)
        //{
        //    return @"
        //            <html>
        //                <head>
        //                    <title>Hello World</title>
        //                </head>
        //                <body>
        //                    <p>Hello <span style=""color:red"">" + id + @"</span></p>
        //                </body>
        //            </html>";
        //}
    }
}