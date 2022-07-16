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
    public class RemuneracaoController : Controller
    {
        #region MAPEAMENTO
        private readonly IRemuneracaoAppService _remuneracaoAppService;
        private readonly IFuncionarioAppService _funcionarioAppService;

        public RemuneracaoController(IRemuneracaoAppService remuneracaoAppService, IFuncionarioAppService funcionarioAppService)
        {
            _remuneracaoAppService = remuneracaoAppService;
            _funcionarioAppService = funcionarioAppService;
        }
        #endregion

        #region GET
        // GET: Remuneracao
        public ActionResult Index()
        {
            var remuneracaoViewModel = Mapper.Map<IEnumerable<Remuneracao>, IEnumerable<RemuneracaoViewModel>>(_remuneracaoAppService.GetAll());
            return View(remuneracaoViewModel);
        }

        // GET: Remuneracao/Details/5
        public ActionResult Details(int id)
        {
            var remuneracao = _remuneracaoAppService.GetById(id);
            var remuneracaoViewModel = Mapper.Map<Remuneracao, RemuneracaoViewModel>(remuneracao);
            return View(remuneracaoViewModel);
        }

        // GET: Remuneracao/Create
        public ActionResult Create()
        {
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome");
            return View();
        }

        // GET: Remuneracao/Edit/5
        public ActionResult Edit(int id)
        {
            var remuneracao = _remuneracaoAppService.GetById(id);
            var remuneracaoViewModel = Mapper.Map<Remuneracao, RemuneracaoViewModel>(remuneracao);
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", remuneracaoViewModel.FuncionarioId);
            return View(remuneracaoViewModel);
        }

        // GET: Remuneracao/Delete/5
        public ActionResult Delete(int id)
        {
            var remuneracao = _remuneracaoAppService.GetById(id);
            var remuneracaoViewModel = Mapper.Map<Remuneracao, RemuneracaoViewModel>(remuneracao);
            return View(remuneracaoViewModel);
        }
        #endregion

        #region POST
        // POST: Remuneracao/Create
        [HttpPost]
        public ActionResult Create(RemuneracaoViewModel remuneracao)
        {
            if (ModelState.IsValid)
            {
                var remuneracaoDomain = Mapper.Map<RemuneracaoViewModel, Remuneracao>(remuneracao);
                _remuneracaoAppService.Add(remuneracaoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", remuneracao.FuncionarioId);
            return View(remuneracao);
        }

        // POST: Remuneracao/Edit/5
        [HttpPost]
        public ActionResult Edit(RemuneracaoViewModel remuneracao)
        {
            if (ModelState.IsValid)
            {
                var remuneracaoDomain = Mapper.Map<RemuneracaoViewModel, Remuneracao>(remuneracao);
                _remuneracaoAppService.Update(remuneracaoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", remuneracao.FuncionarioId);
            return View(remuneracao);
        }

        // POST: Remuneracao/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var remuneracao = _remuneracaoAppService.GetById(id);
            _remuneracaoAppService.Remove(remuneracao);

            return RedirectToAction("Index");
        }
        #endregion

    }
}
