using Microsoft.AspNetCore.Mvc;
using TribalwarsKit.DataGetter;
namespace TribalwarsKit.Controllers
{
    public class GetCoordsController : Controller
    {
        public IActionResult Index()
        {
            string server = "pl186";
            string type = "player";
            UpdateData.CheckSync(server,type);


            return View();
        }
    }
}
