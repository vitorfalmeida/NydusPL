using NydusPL.Models;
using NydusPL.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NydusPL.Controllers
{
    public class EmpresaController : Controller
    {
        private readonly IEmpresaService _empresaService;

        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }

        public ActionResult Index()
        {

            var empresas = _empresaService.GetAll();
            return View(empresas);
        }

        public ActionResult Details(int id)
        {
            var empresa = _empresaService.GetById(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _empresaService.Create(empresa);
                return RedirectToAction("Index");
            }

            return View(empresa);
        }

        public ActionResult Edit(int id)
        {
            var empresa = _empresaService.GetById(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Empresa empresa)
        {
            if (ModelState.IsValid)
            {
                _empresaService.Update(empresa);
                return RedirectToAction("Index");
            }
            return View(empresa);
        }

        public ActionResult Delete(int id)
        {
            var empresa = _empresaService.GetById(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }
            return View(empresa);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var empresa = _empresaService.GetById(id);
            if (empresa == null)
            {
                return HttpNotFound();
            }

            _empresaService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
