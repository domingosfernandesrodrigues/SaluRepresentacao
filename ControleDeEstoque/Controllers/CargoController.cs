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
    public class CargoController : Controller
    {
        #region MAPEAMENTO
        private readonly ICargoAppService _cargoAppService;

        public CargoController(ICargoAppService cargoAppService)
        {
            _cargoAppService = cargoAppService;
        }
        #endregion

        #region GET
        // GET: Cargo
        public ActionResult Index()
        {
            var cargoViewModel = Mapper.Map<IEnumerable<Cargo>, IEnumerable<CargoViewModel>>(_cargoAppService.GetAll());
            return View(cargoViewModel);
        }

        // GET: Cargo/Details/5
        public ActionResult Details(int id)
        {
            var cargo = _cargoAppService.GetById(id);
            var cargoViewModel = Mapper.Map<Cargo, CargoViewModel>(cargo);
            return View(cargoViewModel);
        }

        // GET: Cargo/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Cargo/Edit/5
        public ActionResult Edit(int id)
        {
            var cargo = _cargoAppService.GetById(id);
            var cargoViewModel = Mapper.Map<Cargo, CargoViewModel>(cargo);
            return View(cargoViewModel);
        }

        // GET: Cargo/Delete/5
        public ActionResult Delete(int id)
        {
            var cargo = _cargoAppService.GetById(id);
            var cargoViewModel = Mapper.Map<Cargo, CargoViewModel>(cargo);
            return View(cargoViewModel);
        }

        #endregion

        #region POST
        // POST: Cargo/Create
        [HttpPost]
        public ActionResult Create(CargoViewModel cargo)
        {
            if (ModelState.IsValid)
            {
                var cargoDomain = Mapper.Map<CargoViewModel, Cargo>(cargo);
                _cargoAppService.Add(cargoDomain);

                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        // POST: Cargo/Edit/5
        [HttpPost]
        public ActionResult Edit(CargoViewModel cargo)
        {
            if (ModelState.IsValid)
            {
                var cargoDomain = Mapper.Map<CargoViewModel, Cargo>(cargo);
                _cargoAppService.Update(cargoDomain);

                return RedirectToAction("Index");
            }
            return View(cargo);
        }

        // POST: Cargo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var cargo = _cargoAppService.GetById(id);
            _cargoAppService.Remove(cargo);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
