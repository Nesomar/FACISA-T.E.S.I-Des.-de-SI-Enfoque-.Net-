using AutoMapper;
using ProjetoModeloDDD.Aplicacao.Interface;
using ProjetoModeloDDD.ApresentacaoWeb.ViewModels;
using ProjetoModeloDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.ApresentacaoWeb.Controllers
{
    public class ComentarioController : Controller
    {
        private readonly IComentarioAppService _ComentarioAppService;

        public ComentarioController(IComentarioAppService postAppService) => _ComentarioAppService = postAppService;
        // GET: Usuario
        public ActionResult Index()
        {
            var comentarioViewModel = Mapper.Map<IEnumerable<Comentario>, IEnumerable<ComentarioViewModel>>(_ComentarioAppService.BuscarTodos());
            return View(comentarioViewModel);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var comentario = _ComentarioAppService.BuscarPorID(id);
            var comentarioViewModel = Mapper.Map<Comentario, ComentarioViewModel>(comentario);

            return View(comentarioViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ComentarioViewModel comentarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var ComentarioDomain = Mapper.Map<ComentarioViewModel, Comentario>(comentarioViewModel);
                _ComentarioAppService.Adicionar(ComentarioDomain);

                return RedirectToAction("Index");
            }
            return View(comentarioViewModel);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var comentario = _ComentarioAppService.BuscarPorID(id);
            var comentarioViewModel = Mapper.Map<Comentario, ComentarioViewModel>(comentario);

            return View(comentarioViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ComentarioViewModel comentarioViewModel)
        {
            if (ModelState.IsValid)
            {
                var comentarioDomain = Mapper.Map<ComentarioViewModel, Comentario>(comentarioViewModel);
                _ComentarioAppService.Atualizar(comentarioDomain);

                return RedirectToAction("Index");
            }
            return View(comentarioViewModel);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var comentario = _ComentarioAppService.BuscarPorID(id);
            var comentarioViewModel = Mapper.Map<Comentario, ComentarioViewModel>(comentario);

            return View(comentarioViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var post = _ComentarioAppService.BuscarPorID(id);
            _ComentarioAppService.Remover(post);

            return RedirectToAction("Index");
        }
    }
}
