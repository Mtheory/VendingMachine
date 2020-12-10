using Microsoft.AspNetCore.Mvc;
using System.Linq;
using VendingMachine.Models;
using VendingMachine.ViewModels;

namespace VendingMachine.Controllers
{
    public class HomeController : Controller
    {

        private readonly IMachineRepository _machineRepsoitory;

        public HomeController(IMachineRepository machineRepsoitory)
        {
            _machineRepsoitory = machineRepsoitory;
        }

        public IActionResult Index()
        {
            return View(new DrinkViewModel(_machineRepsoitory.GetDrinkTypes));
        }
        public JsonResult GetProcess(int id)
        {
            try
            {
                var result = _machineRepsoitory.GetPrograms.Where(x => x.DrinkId == id).Select(c => c.Actions).ToList();
                return Json(result);
            }
            catch
            {                
                return Json(new { error = "Unable to load program"});
            }
            
        }
    }
}
