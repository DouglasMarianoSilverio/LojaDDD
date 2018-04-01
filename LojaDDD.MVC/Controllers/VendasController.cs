using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.MVC.ViewModels;

namespace LojaDDD.MVC.Controllers
{
    public class VendasController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly IProdutoAppService _produtoApp;
        private readonly IProdutoVendaAppService _produtoVendaApp;
        private readonly IVendaAppService _vendaApp;

        public VendasController(IClienteAppService clienteApp, IProdutoAppService produtoApp, IProdutoVendaAppService produtoVendaApp, IVendaAppService vendaApp)
        {
            _clienteApp = clienteApp;
            _produtoApp = produtoApp;
            _produtoVendaApp = produtoVendaApp;
            _vendaApp = vendaApp;
        }

        // GET: Vendas
        public ActionResult Index()
        {
            var vendaViewModel = Mapper.Map<IEnumerable<Venda>, IEnumerable<VendaViewModel>>(_vendaApp.GetAll());
            return View(vendaViewModel);
        }

        // GET: Vendas/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Vendas/Create
        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "Id", "Nome");
            return View();
        }

        // POST: Vendas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VendaViewModel venda)
        {
            if (ModelState.IsValid)
            {
                var vendaDomain = Mapper.Map<VendaViewModel, Venda>(venda);
                _vendaApp.Add(vendaDomain);
                return RedirectToAction("Index");
            }
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "Id", "Nome");
            return View(venda);
        }

        // GET: Vendas/Edit/5
        public ActionResult Edit(int id)
        {
            var venda = _vendaApp.GetById(id);
            var vendaViewModel = Mapper.Map<Venda, VendaViewModel>(venda);
            ViewBag.ClienteId = new SelectList(_clienteApp.GetAll(), "Id", "Nome");
            vendaViewModel.ValorTotal = vendaViewModel.ProdutosVenda.Sum(pv => pv.ValorTotal);
            return View(vendaViewModel);
        }

        // POST: Vendas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Vendas/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        public virtual ActionResult DeleteItem(int Id)
        {
            return Content("Dados Excluidos");
        }

        // POST: Vendas/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
