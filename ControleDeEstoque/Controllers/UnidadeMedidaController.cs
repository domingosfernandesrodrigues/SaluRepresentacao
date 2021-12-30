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
    public class UnidadeMedidaController : Controller
    {

        #region  MAPEAMENTO

        private readonly IUnidadeMedidaAppService _unidadeMedidaAppService;

        public UnidadeMedidaController(IUnidadeMedidaAppService unidadeMedidaAppService)
        {
            _unidadeMedidaAppService = unidadeMedidaAppService;
        }
        #endregion

        #region GET
        // GET: UnidadeMedida
        public ActionResult Index()
        {
            var unidadeMedidaViewModel = Mapper.Map<IEnumerable<UnidadeMedida>, IEnumerable<UnidadeMedidaViewModel>>(_unidadeMedidaAppService.GetAll());
            return View(unidadeMedidaViewModel);
        }

        // GET: UnidadeMedida/Details/5
        public ActionResult Details(int id)
        {
            var unidadeMedida = _unidadeMedidaAppService.GetById(id);
            var unidadeMedidaViewModel = Mapper.Map<UnidadeMedida, UnidadeMedidaViewModel>(unidadeMedida);
            return View(unidadeMedidaViewModel);
        }

        // GET: UnidadeMedida/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: UnidadeMedida/Edit/5
        public ActionResult Edit(int id)
        {
            var unidadeMedida = _unidadeMedidaAppService.GetById(id);
            var unidadeMedidaViewModel = Mapper.Map<UnidadeMedida, UnidadeMedidaViewModel>(unidadeMedida);
            return View(unidadeMedidaViewModel);
        }

        // GET: UnidadeMedida/Delete/5
        public ActionResult Delete(int id)
        {
            var unidadeMedida = _unidadeMedidaAppService.GetById(id);
            var unidadeMedidaViewModel = Mapper.Map<UnidadeMedida, UnidadeMedidaViewModel>(unidadeMedida);
            return View(unidadeMedidaViewModel);
        }
        #endregion

        #region POST
        // POST: UnidadeMedida/Create
        [HttpPost]
        public ActionResult Create(UnidadeMedidaViewModel UnidadeMedida)
        {
            if (ModelState.IsValid)
            {
                var UnidadeMedidaDomain = Mapper.Map<UnidadeMedidaViewModel, UnidadeMedida>(UnidadeMedida);
                _unidadeMedidaAppService.Add(UnidadeMedidaDomain);

                return RedirectToAction("Index");
            }
            return View(UnidadeMedida);
        }

        
        // POST: UnidadeMedida/Edit/5
        [HttpPost]
        public ActionResult Edit(UnidadeMedidaViewModel UnidadeMedida)
        {
            if (ModelState.IsValid)
            {
                var UnidadeMedidaDomain = Mapper.Map<UnidadeMedidaViewModel, UnidadeMedida>(UnidadeMedida);
                _unidadeMedidaAppService.Update(UnidadeMedidaDomain);

                return RedirectToAction("Index");
            }
            return View(UnidadeMedida);
        }

        
        // POST: UnidadeMedida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var unidadeMedida = _unidadeMedidaAppService.GetById(id);
            _unidadeMedidaAppService.Remove(unidadeMedida);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
