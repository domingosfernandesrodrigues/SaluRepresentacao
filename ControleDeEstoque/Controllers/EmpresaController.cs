using AutoMapper;
using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class EmpresaController : Controller
    {
        #region MAPEAMENTO
        private readonly IEmpresaAppService _empresaAppService;

        public EmpresaController(IEmpresaAppService empresaAppService)
        {
            _empresaAppService = empresaAppService;
        }
        #endregion]

        #region GET
        // GET: Empresa
        public ActionResult Index()
        {
            var empresaViewModel = Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(_empresaAppService.GetAll());
            return View(empresaViewModel);
        }

        // GET: Empresa/Details/5
        public ActionResult Details(int id)
        {
            var empresa = _empresaAppService.GetById(id);
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(empresa);
            return View(empresaViewModel);
        }

        // GET: Empresa/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Empresa/Edit/5
        public ActionResult Edit(int id)
        {
            var empresa = _empresaAppService.GetById(id);
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(empresa);
            return View(empresaViewModel);
        }

        // GET: Empresa/Delete/5
        public ActionResult Delete(int id)
        {
            var empresa = _empresaAppService.GetById(id);
            var empresaViewModel = Mapper.Map<Empresa, EmpresaViewModel>(empresa);
            return View(empresaViewModel);
        }

        #endregion

        #region POST
        // POST: Empresa/Create
        [HttpPost]
        public ActionResult Create(EmpresaViewModel empresa)
        {
            if (ModelState.IsValid)
            {
                var empresaDomain = Mapper.Map<EmpresaViewModel, Empresa>(empresa);
                _empresaAppService.Add(empresaDomain);

                return RedirectToAction("Index");
            }            
            return View(empresa);
        }

        // POST: Empresa/Edit/5
        [HttpPost]
        public ActionResult Edit(EmpresaViewModel empresa)
        {
            if (ModelState.IsValid)
            {
                var empresaDomain = Mapper.Map<EmpresaViewModel, Empresa>(empresa);
                _empresaAppService.Update(empresaDomain);

                return RedirectToAction("Index");
            }
            return View(empresa);
        }

        // POST: Empresa/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var empresa = _empresaAppService.GetById(id);
            _empresaAppService.Remove(empresa);

            return RedirectToAction("Index");
        }

        #endregion

    }
}
