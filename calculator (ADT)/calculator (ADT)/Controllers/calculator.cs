using Microsoft.AspNetCore.Mvc;

namespace calculator__ADT_.Controllers
{
    public class calculator : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(string expression)
        {
            try
            {
                var result = new System.Data.DataTable().Compute(expression, null);
                return Json(result);
            }
            catch
            {
                return Json("Error");
            }
        }
    }
}
 
