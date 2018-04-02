using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using LojaDDD.Application.Interface;
using LojaDDD.Domain.Entities;
using LojaDDD.MVC.ViewModels;

namespace LojaDDD.MVC.Controllers
{ 
    public class ClientesController : Controller
    {

        private readonly IClienteAppService _clienteApp;

        public ClientesController(IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
        }


        // GET: Clientes
        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteApp.GetAll());
            return View(clienteViewModel);
        }

        

        // GET: Clientes/Details/5
        public ActionResult Details(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteApp.Add(clienteDomain);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public ActionResult Edit(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }

        // POST: Clientes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClienteViewModel cliente)
        {
            if (ModelState.IsValid)
            {
                var clienteDomain = Mapper.Map<ClienteViewModel, Cliente>(cliente);
                _clienteApp.Update(clienteDomain);

                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
        {
            var cliente = _clienteApp.GetById(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
            return View(clienteViewModel);
        }


        //ler sobre ActionName e ValidateAnti
        // POST: Clientes/Delete/5
        [HttpPost,ActionName("delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = _clienteApp.GetById(id);

            if (!_clienteApp.ValidarExclusao(cliente))
            {
                ViewBag.Alerta = "Cliente possui vendas cadastras.";
                var clienteModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);
                return View(clienteModel);
            }

            _clienteApp.Remove(cliente);
            return RedirectToAction("Index");
        }
    }
}
