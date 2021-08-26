using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaWebVuelos.Data;
using SistemaWebVuelos.Models;

namespace SistemaWebVuelos.Controllers
{
    public class VueloController : Controller
    {
        private readonly DbVueloContext context;

        public VueloController(DbVueloContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var vuelos = context.Vuelos.ToList();
            return View(vuelos);
        }

        public IActionResult Create()
        {
            Vuelo vuelo = new Vuelo();
            return View(vuelo);
        }

        [HttpPost]
        public IActionResult Create(Vuelo vuelo)
        {
            if (ModelState.IsValid)
            {
                context.Vuelos.Add(vuelo);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("Create", vuelo);
            }
        }
    }
}
