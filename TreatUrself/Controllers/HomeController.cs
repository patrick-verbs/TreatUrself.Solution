using Microsoft.AspNetCore.Mvc;

namespace TreatUrself.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}