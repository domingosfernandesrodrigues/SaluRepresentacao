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
    public class TipoPagamentoController : Controller
    {

        #region MAPEAMENTO
        private readonly ITipoPagamentoAppService _tipoPagamentoAppService;

        public TipoPagamentoController(ITipoPagamentoAppService tipoPagamentoAppService)
        {
            _tipoPagamentoAppService = tipoPagamentoAppService;
        }

        #endregion

        #region GET
        // GET: TipoPagamento
        public ActionResult Index()
        {
            var tipoPagamentoViewModel = Mapper.Map<IEnumerable<TipoPagamento>, IEnumerable<TipoPagamentoViewModel>>(_tipoPagamentoAppService.GetAll());
            return View(tipoPagamentoViewModel);
        }

        // GET: TipoPagamento/Details/5
        public ActionResult Details(int id)
        {
            var tipoPagamento = _tipoPagamentoAppService.GetById(id);
            var tipoPagamentoViewModel = Mapper.Map<TipoPagamento, TipoPagamentoViewModel>(tipoPagamento);
            return View(tipoPagamentoViewModel);
        }

        // GET: TipoPagamento/Create
        public ActionResult Create()
        {
            return View();
        }
        // GET: TipoPagamento/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoPagamento = _tipoPagamentoAppService.GetById(id);
            var tipoPagamentoViewModel = Mapper.Map<TipoPagamento, TipoPagamentoViewModel>(tipoPagamento);
            return View(tipoPagamentoViewModel);
        }
        // GET: TipoPagamento/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoPagamento = _tipoPagamentoAppService.GetById(id);
            var tipoPagamentoViewModel = Mapper.Map<TipoPagamento, TipoPagamentoViewModel>(tipoPagamento);
            return View(tipoPagamentoViewModel);
        }
        #endregion

        #region POST
        // POST: TipoPagamento/Create
        [HttpPost]
        public ActionResult Create(TipoPagamentoViewModel tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                var tipoPagamentoDomain = Mapper.Map<TipoPagamentoViewModel, TipoPagamento>(tipoPagamento);
                _tipoPagamentoAppService.Add(tipoPagamentoDomain);

                return RedirectToAction("Index");
            }
            return View(tipoPagamento);
        }        

        // POST: TipoPagamento/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoPagamentoViewModel tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                var tipoPagamentoDomain = Mapper.Map<TipoPagamentoViewModel, TipoPagamento>(tipoPagamento);
                _tipoPagamentoAppService.Update(tipoPagamentoDomain);

                return RedirectToAction("Index");
            }
            return View(tipoPagamento);
        }

        // POST: TipoPagamento/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var tipoPagamento = _tipoPagamentoAppService.GetById(id);
            _tipoPagamentoAppService.Remove(tipoPagamento);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
