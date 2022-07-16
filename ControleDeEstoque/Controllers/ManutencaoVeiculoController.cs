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
    public class ManutencaoVeiculoController : Controller
    {
        #region MAPEAMENTO
        private readonly IManutencaoVeiculoAppService _manutencaoVeiculoAppService;
        private readonly IVeiculoAppService _veiculoAppService;               

        public ManutencaoVeiculoController(IManutencaoVeiculoAppService manutencaoVeiculoAppService, IVeiculoAppService veiculoAppService)
        {
            _manutencaoVeiculoAppService = manutencaoVeiculoAppService;
            _veiculoAppService = veiculoAppService;
        }
        #endregion

        #region GET
        // GET: ManutencaoVeiculo
        public ActionResult Index()
        {
            var manutencaoVeiculoViewModel = Mapper.Map<IEnumerable<ManutencaoVeiculo>, IEnumerable<ManutencaoVeiculoViewModel>>(_manutencaoVeiculoAppService.GetAll());
            return View(manutencaoVeiculoViewModel);
        }

        // GET: ManutencaoVeiculo/Details/5
        public ActionResult Details(int id)
        {
            var manutencaoveiculo = _manutencaoVeiculoAppService.GetById(id);
            var manutencaoveiculoViewModel = Mapper.Map<ManutencaoVeiculo, ManutencaoVeiculoViewModel>(manutencaoveiculo);
            return View(manutencaoveiculoViewModel);
        }

        // GET: ManutencaoVeiculo/Create
        public ActionResult Create()
        {
            ViewBag.Veiculo = new SelectList(_veiculoAppService.GetAll(), "VeiculoId", "Modelo");
            return View();
        }

        // GET: ManutencaoVeiculo/Edit/5
        public ActionResult Edit(int id)
        {
            var manutencaoveiculo = _manutencaoVeiculoAppService.GetById(id);
            var manutencaoveiculoViewModel = Mapper.Map<ManutencaoVeiculo, ManutencaoVeiculoViewModel>(manutencaoveiculo);
            ViewBag.Veiculo = new SelectList(_veiculoAppService.GetAll(), "VeiculoId", "Modelo", manutencaoveiculoViewModel.VeiculoId);
            return View(manutencaoveiculoViewModel);
        }

        // GET: ManutencaoVeiculo/Delete/5
        public ActionResult Delete(int id)
        {
            var manutencaoveiculo = _manutencaoVeiculoAppService.GetById(id);
            var manutencaoveiculoViewModel = Mapper.Map<ManutencaoVeiculo, ManutencaoVeiculoViewModel>(manutencaoveiculo);
            return View(manutencaoveiculoViewModel);
        }
        #endregion

        #region POST
        // POST: ManutencaoVeiculo/Create
        [HttpPost]
        public ActionResult Create(ManutencaoVeiculoViewModel manutencaoveiculo)
        {
            if (ModelState.IsValid)
            {
                var manutencaoveiculoDomain = Mapper.Map<ManutencaoVeiculoViewModel, ManutencaoVeiculo>(manutencaoveiculo);
                _manutencaoVeiculoAppService.Add(manutencaoveiculoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Veiculo = new SelectList(_veiculoAppService.GetAll(), "VeiculoId", "Modelo", manutencaoveiculo.VeiculoId);
            return View(manutencaoveiculo);
        }

        // POST: ManutencaoVeiculo/Edit/5
        [HttpPost]
        public ActionResult Edit(ManutencaoVeiculoViewModel manutencaoveiculo)
        {
            if (ModelState.IsValid)
            {
                var manutencaoveiculoDomain = Mapper.Map<ManutencaoVeiculoViewModel, ManutencaoVeiculo>(manutencaoveiculo);
                _manutencaoVeiculoAppService.Update(manutencaoveiculoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Veiculo = new SelectList(_veiculoAppService.GetAll(), "VeiculoId", "Modelo", manutencaoveiculo.VeiculoId);
            return View(manutencaoveiculo);
        }

        // POST: ManutencaoVeiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var manutencaoveiculo = _manutencaoVeiculoAppService.GetById(id);
            _manutencaoVeiculoAppService.Remove(manutencaoveiculo);

            return RedirectToAction("Index");
        }
        #endregion

    }
}
