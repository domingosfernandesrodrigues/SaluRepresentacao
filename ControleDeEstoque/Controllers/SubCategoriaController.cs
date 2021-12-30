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
    public class SubCategoriaController : Controller
    {
        #region MAPEAMENTO

        private readonly ISubCategoriaAppService _subCategoriaAppService;
        private readonly ICategoriaAppService _categoriaAppService;

        public SubCategoriaController(ISubCategoriaAppService subCategoriaAppService, ICategoriaAppService categoriaAppService)
        {
            _subCategoriaAppService = subCategoriaAppService;
            _categoriaAppService = categoriaAppService;
        }

        #endregion

        #region GET
        // GET: SubCategoria
        public ActionResult Index()
        {
            var subcategoriaViewModel = Mapper.Map<IEnumerable<SubCategoria>, IEnumerable<SubCategoriaViewModel>>(_subCategoriaAppService.GetAll());
            return View(subcategoriaViewModel);
        }

        // GET: SubCategoria/Details/5
        public ActionResult Details(int id)
        {
            var subcategoria = _subCategoriaAppService.GetById(id);
            var subcategoriaViewModel = Mapper.Map<SubCategoria, SubCategoriaViewModel>(subcategoria);

            return View(subcategoriaViewModel);
        }

        // GET: SubCategoria/Create
        public ActionResult Create()
        {
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome");
            return View();
        }

        // GET: SubCategoria/Edit/5
        public ActionResult Edit(int id)
        {
            var subcategoria = _subCategoriaAppService.GetById(id);
            var subcategoriaViewModel = Mapper.Map<SubCategoria, SubCategoriaViewModel>(subcategoria);
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", subcategoriaViewModel.CategoriaId);
            return View(subcategoriaViewModel);
        }

        // GET: SubCategoria/Delete/5
        public ActionResult Delete(int id)
        {
            var subcategoria = _subCategoriaAppService.GetById(id);
            var subcategoriaViewModel = Mapper.Map<SubCategoria, SubCategoriaViewModel>(subcategoria);

            return View(subcategoriaViewModel);
        }

        #endregion

        #region POST

        // POST: SubCategoria/Create
        [HttpPost]
        public ActionResult Create(SubCategoriaViewModel subcategoria)
        {
            if (ModelState.IsValid)
            {
                var subCategoriaDomain = Mapper.Map<SubCategoriaViewModel, SubCategoria>(subcategoria);
                _subCategoriaAppService.Add(subCategoriaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", subcategoria.CategoriaId);
            return View(subcategoria);
        }

        
        // POST: SubCategoria/Edit/5
        [HttpPost]
        public ActionResult Edit(SubCategoriaViewModel subcategoria)
        {
            if (ModelState.IsValid)
            {
                var subCategoriaDomain = Mapper.Map<SubCategoriaViewModel, SubCategoria>(subcategoria);
                _subCategoriaAppService.Update(subCategoriaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", subcategoria.CategoriaId);
            return View(subcategoria);
        }


        // POST: SubCategoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var subCategoria = _subCategoriaAppService.GetById(id);
            _subCategoriaAppService.Remove(subCategoria);

            return RedirectToAction("Index");
        }
        #endregion
    }
}
