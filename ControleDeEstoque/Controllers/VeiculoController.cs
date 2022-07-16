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
    public class VeiculoController : Controller
    {
        #region MAPEAMENTO
        private readonly IVeiculoAppService _veiculoAppService;
        private readonly IEmpresaAppService _empresaAppService;

        public VeiculoController(IVeiculoAppService veiculoAppService, IEmpresaAppService empresaAppService)
        {
            _veiculoAppService = veiculoAppService;
            _empresaAppService = empresaAppService;
        }
        #endregion

        #region GET
        // GET: Veiculo
        public ActionResult Index()
        {
            var veiculoViewModel = Mapper.Map<IEnumerable<Veiculo>, IEnumerable<VeiculoViewModel>>(_veiculoAppService.GetAll());
            return View(veiculoViewModel);
        }

        // GET: Veiculo/Details/5
        public ActionResult Details(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }

        // GET: Veiculo/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Veiculo/Edit/5
        public ActionResult Edit(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }

        // GET: Veiculo/Delete/5
        public ActionResult Delete(int id)
        {
            var veiculo = _veiculoAppService.GetById(id);
            var veiculoViewModel = Mapper.Map<Veiculo, VeiculoViewModel>(veiculo);
            return View(veiculoViewModel);
        }
        #endregion

        #region POST
        // POST: Veiculo/Create
        [HttpPost]
        public ActionResult Create(VeiculoViewModel veiculo)
        {
            if (ModelState.IsValid)
            {
                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                var empresa = _empresaAppService.GetAll().FirstOrDefault().EmpresaId;
                veiculoDomain.EmpresaId = empresa;
                _veiculoAppService.Add(veiculoDomain);

                return RedirectToAction("Index");
            }            
            return View(veiculo);
        }

        // POST: Veiculo/Edit/5
        [HttpPost]
        public ActionResult Edit(VeiculoViewModel veiculo)
        {
            if (ModelState.IsValid)
            {
                var veiculoDomain = Mapper.Map<VeiculoViewModel, Veiculo>(veiculo);
                var empresa = _empresaAppService.GetAll().FirstOrDefault().EmpresaId;
                veiculoDomain.EmpresaId = empresa;
                _veiculoAppService.Update(veiculoDomain);

                return RedirectToAction("Index");
            }
            return View(veiculo);
        }

        // POST: Veiculo/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var veiculo = _empresaAppService.GetById(id);
            _empresaAppService.Remove(veiculo);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
