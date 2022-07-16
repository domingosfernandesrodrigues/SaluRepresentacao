using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.ViewModels;

namespace ControleDeEstoque.Controllers
{
    public class ComprasController : Controller
    {

        #region MAPEAMENTO
        private readonly IItensCompraAppService _itensCompraAppService;
        private readonly ICompraAppService _compraAppService;
        private readonly IProdutoAppService _produtoAppService;
        private readonly IFornecedorAppService _fornecedorAppService;
        private readonly ITipoPagamentoAppService _tipoPagamentoAppService;
        private readonly IEmpresaAppService _empresaAppService;
        

        public ComprasController(IItensCompraAppService itensCompraAppService, ICompraAppService compraAppService, IProdutoAppService produtoAppService, IFornecedorAppService fornecedorAppService, ITipoPagamentoAppService tipoPagamentoAppService, IEmpresaAppService empresaAppService)
        {
            _itensCompraAppService = itensCompraAppService;
            _compraAppService = compraAppService;
            _produtoAppService = produtoAppService;
            _fornecedorAppService = fornecedorAppService;
            _tipoPagamentoAppService = tipoPagamentoAppService;
            _empresaAppService = empresaAppService;


        }
        #endregion

        #region GET

        // GET: ItensCompras
        public ActionResult Index()
        {
            var itenCompraModel = Mapper.Map<IEnumerable<ItensCompra>, IEnumerable<ItensCompraViewModel>>(_itensCompraAppService.GetAll());
            return View(itenCompraModel);
        }

        // GET: ItensCompras/Details/5
        public ActionResult Details(int id)
        {
            var itensCompra = _itensCompraAppService.GetById(id);
            var itensCompraViewModel = Mapper.Map<ItensCompra, ItensCompraViewModel>(itensCompra);
            return View(itensCompraViewModel);
        }

        // GET: ItensCompras/Create
        public ActionResult Create()
        {
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome");
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome");
            ViewBag.Produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome");
            ViewBag.compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal");            
            return View();
        }

        // GET: ItensCompras/Edit/5
        public ActionResult Edit(int id)
        {
            var itensCompra = _itensCompraAppService.GetById(id);
            var itensCompraViewModel = Mapper.Map<ItensCompra, ItensCompraViewModel>(itensCompra);
            ViewBag.compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal", itensCompraViewModel.CompraId);
            ViewBag.produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", itensCompraViewModel.ProdutoId);
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome", itensCompraViewModel.Compra.FornecedorId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", itensCompraViewModel.Compra.TipoPagamentoId);
            return View(itensCompraViewModel);
        }

        // GET: ItensCompras/Delete/5
        public ActionResult Delete(int id)
        {
            var itensCompra = _itensCompraAppService.GetById(id);
            var itensCompraViewModel = Mapper.Map<ItensCompra, ItensCompraViewModel>(itensCompra);

            return View(itensCompraViewModel);
        }

        #endregion

        #region POST

        // POST: ItensCompras/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItensCompraViewModel itensCompra)
        {
            if (ModelState.IsValid)
            {
                var itensCompraDomain = Mapper.Map<ItensCompraViewModel, ItensCompra>(itensCompra);
                var empresa = _empresaAppService.GetAll().FirstOrDefault().EmpresaId;
                itensCompraDomain.Compra.EmpresaId = empresa;
                _itensCompraAppService.Add(itensCompraDomain);                

                return RedirectToAction("Index");
            }
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome", itensCompra.Compra.FornecedorId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", itensCompra.Compra.TipoPagamentoId);
            ViewBag.compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal", itensCompra.CompraId);
            ViewBag.produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", itensCompra.ProdutoId);
            ViewBag.empresa = new SelectList(_empresaAppService.GetAll(), "EmpresaId", "Nome", itensCompra.Compra.EmpresaId);
            return View(itensCompra);
        }

        // POST: ItensCompras/Edit/5
        [HttpPost]
        public ActionResult Edit(ItensCompraViewModel itensCompra)
        {
            if (ModelState.IsValid)
            {
                var itensCompraDomain = Mapper.Map<ItensCompraViewModel, ItensCompra>(itensCompra);
                var empresa = _empresaAppService.GetAll().FirstOrDefault().EmpresaId;
                itensCompraDomain.Compra.EmpresaId = empresa;
                _itensCompraAppService.Update(itensCompraDomain);

                var CompraDomain = Mapper.Map<CompraViewModel, Compra>(itensCompra.Compra);
                _compraAppService.Update(CompraDomain);

                return RedirectToAction("Index");
            }
            ViewBag.Fornecedor = new SelectList(_fornecedorAppService.GetAll(), "FornecedorId", "Nome", itensCompra.Compra.FornecedorId);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", itensCompra.Compra.TipoPagamentoId);
            ViewBag.compra = new SelectList(_compraAppService.GetAll(), "CompraId", "NotaFiscal", itensCompra.CompraId);
            ViewBag.produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", itensCompra.Produto.ProdutoId);
            ViewBag.empresa = new SelectList(_empresaAppService.GetAll(), "EmpresaId", "Nome", itensCompra.Compra.EmpresaId);
            return View(itensCompra);
        }

        // POST: ItensCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var itensCompra = _itensCompraAppService.GetById(id);
            _itensCompraAppService.Remove(itensCompra);
            var compra = _compraAppService.GetById(itensCompra.CompraId);
            _compraAppService.Remove(compra);           

            return RedirectToAction("Index");
        }

        #endregion
    }
}
