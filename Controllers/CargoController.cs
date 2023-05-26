using NydusPL.Models;
using NydusPL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NydusPL.Controllers
{
    public class CargoController : Controller
    {
        private readonly ICargoService _cargoService;

        public CargoController(ICargoService cargoService)
        {
            _cargoService = cargoService;
        }

        public ActionResult Index()
        {
            var cargos = _cargoService.GetAll();
            return View(cargos);
        }

        public ActionResult Details(int id)
        {
            var cargo = _cargoService.GetById(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                _cargoService.Create(cargo);
                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        public ActionResult Edit(int id)
        {
            var cargo = _cargoService.GetById(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cargo cargo)
        {
            if (ModelState.IsValid)
            {
                _cargoService.Update(cargo);
                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        public ActionResult Delete(int id)
        {
            var cargo = _cargoService.GetById(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }
            return View(cargo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cargo = _cargoService.GetById(id);
            if (cargo == null)
            {
                return HttpNotFound();
            }

            _cargoService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
