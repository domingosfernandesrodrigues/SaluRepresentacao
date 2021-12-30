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
    public class CategoriaController : Controller
    {

        #region MAPEAMENTO
        private readonly ICategoriaAppService _categoriaAppService;

        public CategoriaController(ICategoriaAppService categoriaAppService)
        {
            _categoriaAppService = categoriaAppService;
        }

        #endregion

        #region GET

        // GET: Categoria
        public ActionResult Index()
        {
            var categoriaViewModel = Mapper.Map<IEnumerable<Categoria>, IEnumerable<CategoriaViewModel>>(_categoriaAppService.GetAll());
            return View(categoriaViewModel);
        }

        // GET: Categoria/Details/5
        public ActionResult Details(int id)
        {
            var categoria = _categoriaAppService.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);
            return View(categoriaViewModel);
        }

        // GET: Categoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: Categoria/Edit/5
        public ActionResult Edit(int id)
        {
            var categoria = _categoriaAppService.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);
            return View(categoriaViewModel);
        }

        // GET: Categoria/Delete/5
        public ActionResult Delete(int id)
        {
            var categoria = _categoriaAppService.GetById(id);
            var categoriaViewModel = Mapper.Map<Categoria, CategoriaViewModel>(categoria);
            return View(categoriaViewModel);
        }
        #endregion

        #region POST

        // POST: Categoria/Create
        [HttpPost]
        public ActionResult Create(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaAppService.Add(categoriaDomain);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }
                
        // POST: Categoria/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoriaViewModel categoria)
        {
            if (ModelState.IsValid)
            {
                var categoriaDomain = Mapper.Map<CategoriaViewModel, Categoria>(categoria);
                _categoriaAppService.Update(categoriaDomain);

                return RedirectToAction("Index");
            }
            return View(categoria);
        }



        // POST: Categoria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var categoria = _categoriaAppService.GetById(id);
            _categoriaAppService.Remove(categoria);

            return RedirectToAction("Index");
        }

        #endregion
    }
}
