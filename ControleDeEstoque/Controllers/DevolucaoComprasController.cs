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
    public class DevolucaoComprasController : Controller
    {

        #region MAPEAMENTO
        private readonly IDevolucaoComprasAppService _devolucaoComprasAppService;
        private readonly ICompraAppService _compraAppService;

        public DevolucaoComprasController(IDevolucaoComprasAppService devolucaoComprasAppService, ICompraAppService compraAppService)
        {
            _devolucaoComprasAppService = devolucaoComprasAppService;
            _compraAppService = compraAppService;
        }
        #endregion

        #region GET
        // GET: DevolucaoCompras
        public ActionResult Index()
        {
            var devolucaoComprasViewModel = Mapper.Map<IEnumerable<DevolucaoCompras>, IEnumerable<DevolucaoComprasViewModel>>(_devolucaoComprasAppService.GetAll());
            return View(devolucaoComprasViewModel);
        }

        // GET: DevolucaoCompras/Details/5
        public ActionResult Details(int id)
        {
            var devolucaoCompras = _devolucaoComprasAppService.GetById(id);
            var devolucaoComprasViewModel = Mapper.Map<DevolucaoCompras, DevolucaoComprasViewModel>(devolucaoCompras);
            return View(devolucaoComprasViewModel);
        }

        // GET: DevolucaoCompras/Create
        public ActionResult Create()
        {
            ViewBag.Compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal");
            return View();
        }

        // GET: DevolucaoCompras/Edit/5
        public ActionResult Edit(int id)
        {
            var devolucaoCompras = _devolucaoComprasAppService.GetById(id);
            var devolucaoComprasViewModel = Mapper.Map<DevolucaoCompras, DevolucaoComprasViewModel>(devolucaoCompras);
            ViewBag.Compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal", devolucaoComprasViewModel.CompraId);
            return View(devolucaoComprasViewModel);
        }

        // GET: DevolucaoCompras/Delete/5
        public ActionResult Delete(int id)
        {
            var devolucaoCompras = _devolucaoComprasAppService.GetById(id);
            var devolucaoComprasViewModel = Mapper.Map<DevolucaoCompras, DevolucaoComprasViewModel>(devolucaoCompras);
            return View(devolucaoComprasViewModel);
        }

        #endregion

        #region POST
        // POST: DevolucaoCompras/Create
        [HttpPost]
        public ActionResult Create(DevolucaoComprasViewModel devolucaoCompras)
        {
            if (ModelState.IsValid)
            {
                var devolucaoComprasDomain = Mapper.Map<DevolucaoComprasViewModel, DevolucaoCompras>(devolucaoCompras);
                _devolucaoComprasAppService.Add(devolucaoComprasDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal", devolucaoCompras.CompraId);
            return View(devolucaoCompras);
        }

        // POST: DevolucaoCompras/Edit/5
        [HttpPost]
        public ActionResult Edit(DevolucaoComprasViewModel devolucaoCompras)
        {
            if (ModelState.IsValid)
            {
                var devolucaoComprasDomain = Mapper.Map<DevolucaoComprasViewModel, DevolucaoCompras>(devolucaoCompras);
                _devolucaoComprasAppService.Update(devolucaoComprasDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal", devolucaoCompras.CompraId);
            return View(devolucaoCompras);
        }

        // POST: DevolucaoCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var devolucaoCompras = _devolucaoComprasAppService.GetById(id);
            _devolucaoComprasAppService.Remove(devolucaoCompras);

            return RedirectToAction("Index");
        }
        #endregion

    }
}
