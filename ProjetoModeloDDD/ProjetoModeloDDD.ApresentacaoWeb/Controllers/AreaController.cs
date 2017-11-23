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
    public class AreaController : Controller
    {
        private readonly IAreaAppService _areaAppService;

        public AreaController(IAreaAppService areaAppService) => _areaAppService = areaAppService;
        // GET: Usuario
        public ActionResult Index()
        {
            var areaViewModel = Mapper.Map<IEnumerable<Area>, IEnumerable<AreaViewModel>>(_areaAppService.BuscarTodos());
            return View(areaViewModel);
        }

        // GET: Usuario/Details/5
        public ActionResult Details(int id)
        {
            var area = _areaAppService.BuscarPorID(id);
            var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);

            return View(areaViewModel);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Usuario/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AreaViewModel areaViewModel)
        {
            if (ModelState.IsValid)
            {
                var areaDomain = Mapper.Map<AreaViewModel, Area>(areaViewModel);
                _areaAppService.Adicionar(areaDomain);

                return RedirectToAction("Index");
            }
            return View(areaViewModel);
        }

        // GET: Usuario/Edit/5
        public ActionResult Edit(int id)
        {
            var area = _areaAppService.BuscarPorID(id);
            var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);

            return View(areaViewModel);
        }

        // POST: Usuario/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(AreaViewModel areaViewModel)
        {
            if (ModelState.IsValid)
            {
                var areaDomain = Mapper.Map<AreaViewModel, Area>(areaViewModel);
                _areaAppService.Atualizar(areaDomain);

                return RedirectToAction("Index");
            }
            return View(areaViewModel);
        }

        // GET: Usuario/Delete/5
        public ActionResult Delete(int id)
        {
            var area = _areaAppService.BuscarPorID(id);
            var areaViewModel = Mapper.Map<Area, AreaViewModel>(area);

            return View(areaViewModel);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var post = _areaAppService.BuscarPorID(id);
            _areaAppService.Remover(post);

            return RedirectToAction("Index");
        }
    }
}
