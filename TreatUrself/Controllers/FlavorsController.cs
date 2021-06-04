using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using TreatUrself.Models;
using System.Collections.Generic;
using System.Linq;

namespace TreatUrself.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly TreatUrselfContext _db;

    public FlavorsController(TreatUrselfContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
  }
}