using AutoMapper;
using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.ApresentacaoWeb.ViewModels;
using ProjetoModeloDDD.Dominio.Entidades;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProjetoModeloDDD.ApresentacaoWeb.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioAppService _usuarioAppService;

        public UsuarioController(IUsuarioAppService usuarioAppService)
        {
            _usuarioAppService = usuarioAppService;
        } 

        // GET: Usuario
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioAppService.BuscarTodos());
            return View(usuarioViewModel);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var usuario = _usuarioAppService.BuscarPorID(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel usuarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
                _usuarioAppService.Adicionar(usuarioDomain);

                return RedirectToAction("Index");
            }
            return View(usuarioViewModel);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var usuario = _usuarioAppService.BuscarPorID(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioViewModel usuario)
        {
            if (ModelState.IsValid)
            {
                var usuarioDomain = Mapper.Map<UsuarioViewModel, Usuario>(usuario);
                _usuarioAppService.Atualizar(usuarioDomain);

                return RedirectToAction("Index");
            }
            return View(usuario);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var usuario = _usuarioAppService.BuscarPorID(id);
            var usuarioViewModel = Mapper.Map<Usuario, UsuarioViewModel>(usuario);

            return View(usuarioViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var usuario = _usuarioAppService.BuscarPorID(id);
            _usuarioAppService.Remover(usuario);

            return RedirectToAction("Index");
        }
    }
}
