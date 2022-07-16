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
    public class FuncionarioController : Controller
    {
        #region MAPEAMENTO

        private readonly IFuncionarioAppService _funcionarioAppService;
        private readonly ICargoAppService _cargoAppService;

        public FuncionarioController(IFuncionarioAppService funcionarioAppService, ICargoAppService cargoAppService)
        {
            _funcionarioAppService = funcionarioAppService;
            _cargoAppService = cargoAppService;
        }

        #endregion

        #region GET
        // GET: Funcionario
        public ActionResult Index()
        {
            var funcionarioViewModel = Mapper.Map<IEnumerable<Funcionario>, IEnumerable<FuncionarioViewModel>>(_funcionarioAppService.GetAll());
            return View(funcionarioViewModel);
        }

        // GET: Funcionario/Details/5
        public ActionResult Details(int id)
        {
            var funcionario = _funcionarioAppService.GetById(id);
            var funcionarioViewModel = Mapper.Map<Funcionario, FuncionarioViewModel>(funcionario);
            return View(funcionarioViewModel);
        }

        // GET: Funcionario/Create
        public ActionResult Create()
        {
            ViewBag.Cargo = new SelectList(_cargoAppService.GetAll(), "CargoId", "Nome");
            return View();
        }

        // GET: Funcionario/Edit/5
        public ActionResult Edit(int id)
        {
            
            var funcionario = _funcionarioAppService.GetById(id);
            var funcionarioViewModel = Mapper.Map<Funcionario, FuncionarioViewModel>(funcionario);
            ViewBag.Cargo = new SelectList(_cargoAppService.GetAll(), "CargoId", "Nome", funcionarioViewModel.CargoId);
            return View(funcionarioViewModel);
        }

        // GET: Funcionario/Delete/5
        public ActionResult Delete(int id)
        {
            var funcionario = _funcionarioAppService.GetById(id);
            var funcionarioViewModel = Mapper.Map<Funcionario, FuncionarioViewModel>(funcionario);
            return View(funcionarioViewModel);
        }
        #endregion

        #region POST
        // POST: Funcionario/Create
        [HttpPost]
        public ActionResult Create(FuncionarioViewModel funcionario)
        {
            if (ModelState.IsValid)
            {
                var funcionarioDomain = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionario);
                _funcionarioAppService.Add(funcionarioDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Cargo = new SelectList(_cargoAppService.GetAll(), "CargoId", "Nome", funcionario.CargoId);
            return View(funcionario);
        }

        // POST: Funcionario/Edit/5
        [HttpPost]
        public ActionResult Edit(FuncionarioViewModel funcionario)
        {
            if (ModelState.IsValid)
            {
                var funcionarioDomain = Mapper.Map<FuncionarioViewModel, Funcionario>(funcionario);
                _funcionarioAppService.Update(funcionarioDomain);

                return RedirectToAction("Index");
            }
            return View(funcionario);
        }

        // POST: Funcionario/Delete/5        
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var funcionario = _funcionarioAppService.GetById(id);
            _funcionarioAppService.Remove(funcionario);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
