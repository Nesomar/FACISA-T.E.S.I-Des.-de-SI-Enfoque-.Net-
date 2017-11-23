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
    public class PostController : Controller
    {
        private readonly IPostAppService _postAppService;

        public PostController(IPostAppService postAppService) => _postAppService = postAppService;
        // GET: Usuario
        public ActionResult Index()
        {
            var usuarioViewModel = Mapper.Map<IEnumerable<Post>, IEnumerable<PostViewModel>>(_postAppService.BuscarTodos());
            return View(usuarioViewModel);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var post = _postAppService.BuscarPorID(id);
            var postViewModel = Mapper.Map<Post, PostViewModel>(post);

            return View(postViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostViewModel postViewModel)
        {
            if (ModelState.IsValid)
            {
                var postDomain = Mapper.Map<PostViewModel, Post>(postViewModel);
                _postAppService.Atualizar(postDomain);

                return RedirectToAction("Index");
            }
            return View(postViewModel);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var post = _postAppService.BuscarPorID(id);
            var postViewModel = Mapper.Map<Post, PostViewModel>(post);

            return View(postViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PostViewModel postViewModel)
        {
            if (ModelState.IsValid)
            {
                var postDomain = Mapper.Map<PostViewModel, Post>(postViewModel);
                _postAppService.Atualizar(postDomain);

                return RedirectToAction("Index");
            }
            return View(postViewModel);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var post = _postAppService.BuscarPorID(id);
            var postViewModel = Mapper.Map<Post, PostViewModel>(post);

            return View(postViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var post = _postAppService.BuscarPorID(id);
            _postAppService.Remover(post);

            return RedirectToAction("Index");
        }
    }
}
