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
    public class ProdutoController : Controller
    {

        #region MAPEAMENTO
        private readonly IProdutoAppService _produtoAppService;
        private readonly ISubCategoriaAppService _subCategoriaAppService;
        private readonly ICategoriaAppService _categoriaAppService;
        private readonly IUnidadeMedidaAppService _unidadeMedidaAppService;

        public ProdutoController(IProdutoAppService produtoAppService, ISubCategoriaAppService subCategoriaAppService, ICategoriaAppService categoriaAppService, IUnidadeMedidaAppService unidadeMedidaAppService)
        {
            _produtoAppService = produtoAppService;
            _subCategoriaAppService = subCategoriaAppService;
            _categoriaAppService = categoriaAppService;
            _unidadeMedidaAppService = unidadeMedidaAppService;
        }


        #endregion

        #region GET

        // GET: Produto
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoAppService.GetAll());
            return View(produtoViewModel);
        }

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome");
            ViewBag.SubCategoria = new SelectList(_subCategoriaAppService.GetAll(), "SubCategoriaId", "Nome");
            ViewBag.UnidadeMedida = new SelectList(_unidadeMedidaAppService.GetAll(), "UnidadeMedidaId", "Nome");
            return View();
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", produtoViewModel.CategoriaId);
            ViewBag.SubCategoria = new SelectList(_subCategoriaAppService.GetAll(), "SubCategoriaId", "Nome", produtoViewModel.SubCategoriaId);
            ViewBag.UnidadeMedida = new SelectList(_unidadeMedidaAppService.GetAll(), "UnidadeMedidaId", "Nome", produtoViewModel.UnidadeMedidaId);
            return View(produtoViewModel);
        }

        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoAppService.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);

            return View(produtoViewModel);
        }

        #endregion


        #region POST
        // POST: Produto/Create
        [HttpPost]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoAppService.Add(produtoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", produto.CategoriaId);
            ViewBag.SubCategoria = new SelectList(_subCategoriaAppService.GetAll(), "SubCategoriaId", "Nome", produto.SubCategoriaId);
            ViewBag.UnidadeMedida = new SelectList(_unidadeMedidaAppService.GetAll(), "UnidadeMedidaId", "Nome", produto.UnidadeMedidaId);
            return View(produto);
        }        

        // POST: Produto/Edit/5
        [HttpPost]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoAppService.Update(produtoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Categoria = new SelectList(_categoriaAppService.GetAll(), "CategoriaId", "Nome", produto.CategoriaId);
            ViewBag.SubCategoria = new SelectList(_subCategoriaAppService.GetAll(), "SubCategoriaId", "Nome", produto.SubCategoriaId);
            ViewBag.UnidadeMedida = new SelectList(_unidadeMedidaAppService.GetAll(), "UnidadeMedidaId", "Nome", produto.UnidadeMedidaId);
            return View(produto);
        }


        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoAppService.GetById(id);
            _produtoAppService.Remove(produto);

            return RedirectToAction("Index");
        }

        #endregion
    }
}
