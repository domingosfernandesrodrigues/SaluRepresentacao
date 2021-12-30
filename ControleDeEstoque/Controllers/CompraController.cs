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
    public class CompraController : Controller
    {
        #region MAPEAMENTO

        private readonly ICompraAppService _compraAppService;
        private readonly IFornecedorAppService _fornecedorAppService;
        private readonly ITipoPagamentoAppService _tipoPagamentoAppService;

        public CompraController(ICompraAppService compraAppService, IFornecedorAppService fornecedorAppService, ITipoPagamentoAppService tipoPagamentoAppService)
        {
            _compraAppService = compraAppService;
            _fornecedorAppService = fornecedorAppService;
            _tipoPagamentoAppService = tipoPagamentoAppService;
        }
        #endregion

        #region GET
        // GET: Compra
        public ActionResult Index()
        {
            var compraViewModel = Mapper.Map<IEnumerable<Compra>, IEnumerable<CompraViewModel>>(_compraAppService.GetAll());
            return View(compraViewModel);
        }

        // GET: Compra/Details/5
        public ActionResult Details(int id)
        {
            var compra = _compraAppService.GetById(id);
            var compraViewModel = Mapper.Map<Compra, CompraViewModel>(compra);

            return View(compraViewModel);
        }

        // GET: Compra/Create
        public ActionResult Create()
        {
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome");
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome");
            return View();
        }

        // GET: Compra/Edit/5
        public ActionResult Edit(int id)
        {
            var compra = _compraAppService.GetById(id);
            var compraViewModel = Mapper.Map<Compra, CompraViewModel>(compra);
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome", compraViewModel.FornecedorId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", compraViewModel.TipoPagamentoId);
            return View(compraViewModel);
        }

        // GET: Compra/Delete/5
        public ActionResult Delete(int id)
        {
            var compra = _compraAppService.GetById(id);
            var compraViewModel = Mapper.Map<Compra, CompraViewModel>(compra);
            return View(compraViewModel);
        }
        #endregion

        #region POST
        // POST: Compra/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CompraViewModel compra)
        {
            
            if (ModelState.IsValid)
            {
                var compraDomain = Mapper.Map<CompraViewModel, Compra>(compra);
                _compraAppService.Add(compraDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome", compra.FornecedorId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", compra.TipoPagamentoId);
            return View(compra);

        }        

        // POST: Compra/Edit/5
        [HttpPost]
        public ActionResult Edit(CompraViewModel compra)
        {
            if (ModelState.IsValid)
            {
                var CompraDomain = Mapper.Map<CompraViewModel, Compra>(compra);
                _compraAppService.Update(CompraDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome", compra.FornecedorId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", compra.TipoPagamentoId);
            return View(compra);
        }

        // POST: Compra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var compra = _compraAppService.GetById(id);
            _compraAppService.Remove(compra);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
