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
    public class VendaController : Controller
    {
        #region MAPEAMENTO
        private readonly IVendaAppService _vendaAppService;
        private readonly IClienteAppService _clienteAppService;
        private readonly ITipoPagamentoAppService _tipoPagamentoAppService;        

        public VendaController(IVendaAppService vendaAppService,IClienteAppService clienteAppService, ITipoPagamentoAppService tipoPagamentoAppService)
        {
            _vendaAppService = vendaAppService;
            _clienteAppService = clienteAppService;
            _tipoPagamentoAppService = tipoPagamentoAppService;
        }
        #endregion

        #region GET
        // GET: Venda
        public ActionResult Index()
        {
            var vendaViewModel = Mapper.Map<IEnumerable<Venda>, IEnumerable<VendaViewModel>>(_vendaAppService.GetAll());
            return View(vendaViewModel);
        }

        // GET: Venda/Details/5
        public ActionResult Details(int id)
        {
            var venda = _vendaAppService.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);

            return View(vendaViewModel);
        }

        // GET: Venda/Create
        public ActionResult Create()
        {
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome");
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome");
            return View();
        }

        // GET: Venda/Edit/5
        public ActionResult Edit(int id)
        {
            var venda = _vendaAppService.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", vendaViewModel.ClienteId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", vendaViewModel.TipoPagamentoId);
            return View(vendaViewModel);
        }

        // GET: Venda/Delete/5
        public ActionResult Delete(int id)
        {
            var venda = _vendaAppService.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);
            return View(vendaViewModel);
        }

        #endregion

        #region POST
        // POST: Venda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VendaViewModel venda)
        {
            if (ModelState.IsValid)
            {
                var vendaDomain = Mapper.Map<VendaViewModel, Venda>(venda);
                _vendaAppService.Add(vendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", venda.ClienteId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", venda.TipoPagamentoId);
            return View(venda);
        }

        // POST: Venda/Edit/5
        [HttpPost]
        public ActionResult Edit(VendaViewModel venda)
        {
            if (ModelState.IsValid)
            {
                var vendaDomain = Mapper.Map<VendaViewModel, Venda>(venda);
                _vendaAppService.Update(vendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", venda.ClienteId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", venda.TipoPagamentoId);
            return View(venda);
        }

        // POST: Venda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var venda = _vendaAppService.GetById(id);
            _vendaAppService.Remove(venda);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
