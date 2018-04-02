using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using LojaDDD.Application;
using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.MVC.ViewModels;

namespace LojaDDD.MVC.Controllers
{
    public class ProdutosVendaController : Controller
    {

        private readonly IProdutoVendaAppService _produtoVendaApp;
        private readonly IVendaAppService _vendaApp;
        private readonly IProdutoAppService _produtoApp;

        public ProdutosVendaController(IProdutoVendaAppService produtoVendaApp, IVendaAppService vendaApp, IProdutoAppService produtoApp)
        {
            _produtoVendaApp = produtoVendaApp;
            _vendaApp = vendaApp;
            _produtoApp = produtoApp;
        }

        // GET: ProdutosVenda
        public ActionResult Index()
        {
            var vendas = Mapper.Map<IEnumerable< ProdutoVenda>, IEnumerable<ProdutoVendaViewModel>>(_produtoVendaApp.GetAll());
            return View(vendas);
        }



        // GET: ProdutosVenda/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdutosVenda/Create
//        public ActionResult Create()
//        {
//            ViewBag.VendaId = new SelectList(_vendaApp.GetAll(), "Id", "Id");
//            ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "Id", "Nome");
//            return PartialView();
//        }
        public ActionResult Create(int vendaId)
        {
            //ViewBag.VendaId = _vendaApp.GetById(vendaId);
            var venda = _vendaApp.GetById(vendaId);

            var produtoVenda = new ProdutoVenda();
            produtoVenda.VendaId = venda.Id;
            produtoVenda.Venda = venda;
            var produtoVendaView = Mapper.Map<ProdutoVenda, ProdutoVendaViewModel>(produtoVenda);
            ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "Id", "Nome");
            return PartialView(produtoVendaView);
        }

        // POST: ProdutosVenda/Create
        [HttpPost]
        public ActionResult Create(ProdutoVendaViewModel produtoVenda)
        {
            if (ModelState.IsValid)
            {
                var produtoVendaDomain = Mapper.Map<ProdutoVendaViewModel, ProdutoVenda>(produtoVenda);
                try
                {
                    produtoVendaDomain.Venda = null;
                    produtoVendaDomain.ValorTotal = produtoVenda.Quantidade * produtoVenda.ValorUnitario;
                    _produtoVendaApp.Add(produtoVendaDomain);
                    return RedirectToAction("Edit", "Vendas",new {id = produtoVendaDomain.VendaId} );


                }
                catch (Exception ex)
                {
                    ViewBag.Alerta = "Erro ao cadastrar o item" + ex.Message;
                    ViewBag.VendaId = new SelectList(_vendaApp.GetAll(), "Id", "Id");
                    ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "Id", "Nome");
                    return PartialView(produtoVenda);
                }
            }


            var erros = ModelState.Values.SelectMany(v => v.Errors);

            ViewBag.VendaId = new SelectList(_vendaApp.GetAll(), "Id", "Id");
            ViewBag.ProdutoId = new SelectList(_produtoApp.GetAll(), "Id", "Nome");
            return PartialView(produtoVenda);
        }

        // GET: ProdutosVenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdutosVenda/Edit/5
        [HttpPost]
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

        // GET: ProdutosVenda/Delete/5
        public ActionResult Delete(int id)
        {
            var produtoVenda = _produtoVendaApp.GetById(id);
            var produvoVendaViewModel = Mapper.Map<ProdutoVenda, ProdutoVendaViewModel>(produtoVenda);
            return PartialView(produvoVendaViewModel);
        }

        // POST: ProdutosVenda/Delete/5
        [HttpPost,ActionName("delete")]
        public ActionResult DeleteConfirmed(int id )
        {
            var produtoVenda = _produtoVendaApp.GetById(id);
            var vendaId = produtoVenda.VendaId;
            _produtoVendaApp.Remove(produtoVenda);
            return RedirectToAction("Edit", "Vendas", new { id = vendaId }); ;
        }
    }
}
