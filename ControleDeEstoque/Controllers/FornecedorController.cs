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
    public class FornecedorController : Controller
    {
        #region MAPEAMENTO

        private readonly IFornecedorAppService _fornecedorAppService;

        public FornecedorController(IFornecedorAppService fornecedorAppService)
        {
            _fornecedorAppService = fornecedorAppService;
        }

        #endregion

        #region GET
        // GET: Fornecedor
        public ActionResult Index()
        {
            var fornecedorViewModel = Mapper.Map<IEnumerable<Fornecedor>, IEnumerable<FornecedorViewModel>>(_fornecedorAppService.GetAll());
            return View(fornecedorViewModel);
        }

        // GET: Fornecedor/Details/5
        public ActionResult Details(int id)
        {
            var fornecedor = _fornecedorAppService.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }

        // GET: Fornecedor/Create
        public ActionResult Create()
        {
            return View();
        }
        // GET: Fornecedor/Edit/5
        public ActionResult Edit(int id)
        {
            var fornecedor = _fornecedorAppService.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }
        // GET: Fornecedor/Delete/5
        public ActionResult Delete(int id)
        {
            var fornecedor = _fornecedorAppService.GetById(id);
            var fornecedorViewModel = Mapper.Map<Fornecedor, FornecedorViewModel>(fornecedor);
            return View(fornecedorViewModel);
        }
        #endregion

        #region POST
        // POST: Fornecedor/Create
        [HttpPost]
        public ActionResult Create(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                var fornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor);
                _fornecedorAppService.Add(fornecedorDomain);

                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }        

        // POST: Fornecedor/Edit/5
        [HttpPost]
        public ActionResult Edit(FornecedorViewModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                var fornecedorDomain = Mapper.Map<FornecedorViewModel, Fornecedor>(fornecedor);
                _fornecedorAppService.Update(fornecedorDomain);

                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }        

        // POST: Fornecedor/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var fornecedor = _fornecedorAppService.GetById(id);
            _fornecedorAppService.Remove(fornecedor);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
