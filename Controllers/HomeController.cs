
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SewArtCentr.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace SewArtCentr.Controllers
{
    public class HomeController : Controller
    {
        FashionContext db;
        public HomeController(FashionContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.FashionColls.ToList());
        }


        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return
                     RedirectToAction("Index");
            ViewBag.FashionColl = id;
            return View();
        }

        [HttpPost]
        public string Buy(Order oreder)
        {
            db.Orders.Add(oreder);
            //Сохраняем в бд вск изменеия 
            db.SaveChanges();
            return "Спасибо," + oreder.User + ",за покупку!";
        }

    }
}
    
