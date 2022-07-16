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
    public class AlimentacaoController : Controller
    {

        #region MAPEAMENTO
        private readonly IAlimentacaoAppService _alimentacaoAppService;
        private readonly IFuncionarioAppService _funcionarioAppService;

        public AlimentacaoController(IAlimentacaoAppService alimentacaoAppService, IFuncionarioAppService funcionarioAppService)
        {
            _alimentacaoAppService = alimentacaoAppService;
            _funcionarioAppService = funcionarioAppService;
        }
        #endregion

        #region GET
        // GET: Alimentacao
        public ActionResult Index()
        {
            var alimentacaoViewModel = Mapper.Map<IEnumerable<Alimentacao>, IEnumerable<AlimentacaoViewModel>>(_alimentacaoAppService.GetAll());
            return View(alimentacaoViewModel);
        }

        // GET: Alimentacao/Details/5
        public ActionResult Details(int id)
        {
            var alimentacao = _alimentacaoAppService.GetById(id);
            var alimentacaoViewModel = Mapper.Map<Alimentacao, AlimentacaoViewModel>(alimentacao);
            return View(alimentacaoViewModel);
        }

        // GET: Alimentacao/Create
        public ActionResult Create()
        {
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome");
            return View();
        }

        // GET: Alimentacao/Edit/5
        public ActionResult Edit(int id)
        {
            var alimentacao = _alimentacaoAppService.GetById(id);
            var alimentacaoViewModel = Mapper.Map<Alimentacao, AlimentacaoViewModel>(alimentacao);
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", alimentacaoViewModel.FuncionarioId);
            return View(alimentacaoViewModel);
        }

        // GET: Alimentacao/Delete/5
        public ActionResult Delete(int id)
        {
            var alimentacao = _alimentacaoAppService.GetById(id);
            var alimentacaoViewModel = Mapper.Map<Alimentacao, AlimentacaoViewModel>(alimentacao);
            return View(alimentacaoViewModel);
        }
        #endregion

        #region POST
        // POST: Alimentacao/Create
        [HttpPost]
        public ActionResult Create(AlimentacaoViewModel alimentacao)
        {
            if (ModelState.IsValid)
            {
                var alimentacaoDomain = Mapper.Map<AlimentacaoViewModel, Alimentacao>(alimentacao);
                _alimentacaoAppService.Add(alimentacaoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", alimentacao.FuncionarioId);
            return View(alimentacao);
        }

        // POST: Alimentacao/Edit/5
        [HttpPost]
        public ActionResult Edit(AlimentacaoViewModel alimentacao)
        {
            if (ModelState.IsValid)
            {
                var alimentacaoDomain = Mapper.Map<AlimentacaoViewModel, Alimentacao>(alimentacao);
                _alimentacaoAppService.Update(alimentacaoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", alimentacao.FuncionarioId);
            return View(alimentacao);
        }

        // POST: Alimentacao/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var alimentacao = _alimentacaoAppService.GetById(id);
            _alimentacaoAppService.Remove(alimentacao);

            return RedirectToAction("Index");
        }
        #endregion





    }
}
