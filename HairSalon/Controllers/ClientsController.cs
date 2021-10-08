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
      Console.WriteLine($"Id to pass to client create form: {id}");
      
      ViewBag.StylistId = id;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client client)
    {
      Console.WriteLine($"Id from client create form: {client.StylistId}");
      Console.WriteLine($"Name from client create form: {client.Name}");
      
      _db.Clients.Add(client);
      _db.SaveChanges();
      return RedirectToAction("Details", "Stylists", new { id = client.StylistId });
    }
  }
}
