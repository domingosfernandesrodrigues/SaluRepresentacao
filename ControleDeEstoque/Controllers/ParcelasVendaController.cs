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
    public class ParcelasVendaController : Controller
    {
        #region MAPEAMENTO
        private readonly IParcelasVendaAppService _parcelasVendaAppService;
        private readonly IVendaAppService _vendaAppService;

        public ParcelasVendaController(IParcelasVendaAppService parcelasVendaAppService, IVendaAppService vendaAppService)
        {
            _parcelasVendaAppService = parcelasVendaAppService;
            _vendaAppService = vendaAppService;
        }

        #endregion

        #region GET
        // GET: ParcelasVenda
        public ActionResult Index()
        {
            var parcelasVendaViewModel = Mapper.Map<IEnumerable<ParcelasVenda>, IEnumerable<ParcelasVendaViewModel>>(_parcelasVendaAppService.GetAll());
            return View(parcelasVendaViewModel);
        }

        // GET: ParcelasVenda/Details/5
        public ActionResult Details(int id)
        {
            var parcelasVenda = _parcelasVendaAppService.GetById(id);
            var parcelasVendaViewModel = Mapper.Map<ParcelasVenda, ParcelasVendaViewModel>(parcelasVenda);

            return View(parcelasVendaViewModel);
        }

        // GET: ParcelasVenda/Create
        public ActionResult Create()
        {
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "Nome");
            return View();
        }

        // GET: ParcelasVenda/Edit/5
        public ActionResult Edit(int id)
        {
            var parcelasVenda = _parcelasVendaAppService.GetById(id);
            var parcelasVendaViewModel = Mapper.Map<ParcelasVenda, ParcelasVendaViewModel>(parcelasVenda);
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "Nome", parcelasVendaViewModel.VendaId);
            return View(parcelasVendaViewModel);
        }

        // GET: ParcelasVenda/Delete/5
        public ActionResult Delete(int id)
        {
            var parcelasVenda = _parcelasVendaAppService.GetById(id);
            var parcelasVendaViewModel = Mapper.Map<ParcelasVenda, ParcelasVendaViewModel>(parcelasVenda);
            return View(parcelasVendaViewModel);
        }
        #endregion

        #region POST
        // POST: ParcelasVenda/Create
        [HttpPost]
        public ActionResult Create(ParcelasVendaViewModel parcelasVenda)
        {
            if (ModelState.IsValid)
            {
                var parcelasVendaDomain = Mapper.Map<ParcelasVendaViewModel, ParcelasVenda>(parcelasVenda);
                _parcelasVendaAppService.Add(parcelasVendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "Nome", parcelasVenda.VendaId);
            return View(parcelasVenda);
        }        

        // POST: ParcelasVenda/Edit/5
        [HttpPost]
        public ActionResult Edit(ParcelasVendaViewModel parcelasVenda)
        {
            if (ModelState.IsValid)
            {
                var parcelasVendaDomain = Mapper.Map<ParcelasVendaViewModel, ParcelasVenda>(parcelasVenda);
                _parcelasVendaAppService.Update(parcelasVendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "Nome", parcelasVenda.VendaId);
            return View(parcelasVenda);
        }

        // POST: ParcelasVenda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var parcelasVenda = _parcelasVendaAppService.GetById(id);
            _parcelasVendaAppService.Remove(parcelasVenda);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
