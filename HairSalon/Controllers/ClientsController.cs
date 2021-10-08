using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace HairSalon.Controllers
{
  public class ClientsController : Controller
  {
    private readonly HairSalonContext _db;

    public ClientsController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create(int id)
    {
      Console.WriteLine($"Id: {id}");
      
      ViewBag.StylistId = id;
      return View();
    }

    // [HttpPost]
    // public ActionResult Create(Stylist stylist)
    // {
    //   _db.Stylists.Add(stylist);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}
