using AutoMapper;
using ControleDeEstoque.Application.Interface;
using ControleDeEstoque.Domain.Entities;
using ControleDeEstoque.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace ControleDeEstoque.Controllers
{
    public class VendaController : Controller
    {
        #region MAPEAMENTO
        private readonly IItensVendaAppService _itensVendaAppService;
        private readonly IVendaAppService _vendaAppService;
        private readonly IProdutoAppService _produtoAppService;
        private readonly ITipoPagamentoAppService _tipoPagamentoAppService;
        private readonly IClienteAppService _clienteAppService;
        private readonly IEmpresaAppService _empresaAppService;
        private readonly IFuncionarioAppService _funcionarioAppService;

        public VendaController(IItensVendaAppService itensVendaAppService,IVendaAppService vendaAppService, IProdutoAppService produtoAppService, ITipoPagamentoAppService tipoPagamentoAppService, IClienteAppService clienteAppService, IEmpresaAppService empresaAppService, IFuncionarioAppService funcionarioAppService)
        {
            _itensVendaAppService = itensVendaAppService;
            _vendaAppService = vendaAppService;
            _produtoAppService = produtoAppService;
            _tipoPagamentoAppService = tipoPagamentoAppService;
            _clienteAppService = clienteAppService;
            _empresaAppService = empresaAppService;
            _funcionarioAppService = funcionarioAppService;
        }

        #endregion

        #region GET

        // GET: Venda
        public ActionResult Index()
        {
            var itenVendasModel = Mapper.Map<IEnumerable<ItensVenda>, IEnumerable<ItensVendaViewModel>>(_itensVendaAppService.GetAll());
            return View(itenVendasModel);
        }

        // GET: Venda/Details/5
        public ActionResult Details(int id)
        {

            var itensVendas = _itensVendaAppService.GetById(id);
            var itensVendasViewModel = Mapper.Map<ItensVenda, ItensVendaViewModel>(itensVendas);
            return View(itensVendasViewModel);
        }

        // GET: Venda/Create
        public ActionResult Create()
        {
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome");
            ViewBag.Produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome");
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "NotaFiscal");
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome");
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome");
            return View();
        }

        // GET: Venda/Edit/5
        public ActionResult Edit(int id)
        {
            var itensVenda = _itensVendaAppService.GetById(id);
            var itensVendaViewModel = Mapper.Map<ItensVenda, ItensVendaViewModel>(itensVenda);
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", itensVendaViewModel.Venda.TipoPagamentoId);
            ViewBag.Produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", itensVendaViewModel.ProdutoId);
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "NotaFiscal", itensVendaViewModel.VendaId);
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", itensVendaViewModel.Venda.ClienteId);
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", itensVendaViewModel.Venda.FuncionarioId);
            return View(itensVendaViewModel);
        }

        // GET: Venda/Delete/5
        public ActionResult Delete(int id)
        {
            var itensVenda = _itensVendaAppService.GetById(id);
            var itensVendaViewModel = Mapper.Map<ItensVenda, ItensVendaViewModel>(itensVenda);
            return View(itensVendaViewModel);
        }

        #endregion

        #region POST

        // POST: Venda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItensVendaViewModel itensVenda)
        {
            if(ModelState.IsValid)
            {
                var itensVendaDomain = Mapper.Map<ItensVendaViewModel, ItensVenda >(itensVenda);
                var empresa = _empresaAppService.GetAll().FirstOrDefault().EmpresaId;
                itensVendaDomain.Venda.EmpresaId = empresa;
                _itensVendaAppService.Add(itensVendaDomain);

                return RedirectToAction("Index");
            }
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", itensVenda.Venda.TipoPagamentoId);
            ViewBag.Produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", itensVenda.ProdutoId);
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "NotaFiscal", itensVenda.VendaId);
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", itensVenda.Venda.ClienteId);
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", itensVenda.Venda.FuncionarioId);
            return View(itensVenda);
        }        

        // POST: Venda/Edit/5
        [HttpPost]
        public ActionResult Edit(ItensVendaViewModel itensVenda)
        {
            if (ModelState.IsValid)
            {
                var itensVendaDomain = Mapper.Map<ItensVendaViewModel, ItensVenda>(itensVenda);
                var empresa = _empresaAppService.GetAll().FirstOrDefault().EmpresaId;
                itensVendaDomain.Venda.EmpresaId = empresa;
                _itensVendaAppService.Update(itensVendaDomain);

                var vendaDomain = Mapper.Map<VendaViewModel, Venda>(itensVenda.Venda);
                _vendaAppService.Update(vendaDomain);
                               
                return RedirectToAction("Index");
            }
            ViewBag.TipoPagamento = new SelectList(_tipoPagamentoAppService.GetAll(), "TipoPagamentoId", "Nome", itensVenda.Venda.TipoPagamentoId);
            ViewBag.Produto = new SelectList(_produtoAppService.GetAll(), "ProdutoId", "Nome", itensVenda.ProdutoId);
            ViewBag.Venda = new SelectList(_vendaAppService.GetAll(), "VendaId", "NotaFiscal", itensVenda.VendaId);
            ViewBag.Cliente = new SelectList(_clienteAppService.GetAll(), "ClienteId", "Nome", itensVenda.Venda.ClienteId);
            ViewBag.Empresa = new SelectList(_empresaAppService.GetAll(), "EmpresaId", "Nome", itensVenda.Venda.EmpresaId);
            ViewBag.Funcionario = new SelectList(_funcionarioAppService.GetAll(), "FuncionarioId", "Nome", itensVenda.Venda.FuncionarioId);
            return View(itensVenda);
        }

        // POST: Venda/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var itensVenda = _itensVendaAppService.GetById(id);         
            _itensVendaAppService.Remove(itensVenda);

            var venda = _vendaAppService.GetById(itensVenda.VendaId);
            _vendaAppService.Remove(venda);

            return RedirectToAction("Index");
        }
#endregion
    }
}
