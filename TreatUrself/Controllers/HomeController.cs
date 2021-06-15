using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TreatUrself.Models;

namespace TreatUrself.Controllers
{
  public class HomeController : Controller
  {
    private readonly TreatUrselfContext _db;

    public HomeController(TreatUrselfContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Flavor> allFlavors = _db.Flavors.ToList();
      model.Add("Flavors", allFlavors);
      List<Treat> allTreats = _db.Treats.ToList();
      model.Add("Treats", allTreats);
      return View(model);
    }
  }
}