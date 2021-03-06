﻿using AutoMapper;
using HouseDJ.Musicas.AcessoDados.Entity.Context;
using HouseDJ.Musicas.Dominio;
using HouseDJ.Musicas.Repositorios.Entity;
using HouseDJ.Musicas.Web.ViewModels.Album;
using HouseDJ.Repositorios.Comum;
using System.Collections.Generic;
using System.Net;
using System.Web.Mvc;
using System.Linq;
using HouseDJ.Musicas.Web.Filtros;

namespace HouseDJ.Musicas.Web.Controllers
{
    [Authorize]
    public class AlbunsController : Controller
    {
        private IRepositorioGenerico<Album, int> repositorioAlbuns 
            = new AlbunsRepositorio(new MusicasDbContext());

        // GET: Albuns
        public ActionResult Index()
        {
            return View(Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(repositorioAlbuns.Selecionar()));
        }

        public ActionResult FiltrarPorNome(string pesquisa)
        {
            List<Album> albums = repositorioAlbuns.Selecionar().Where(a => a.Nome.Contains(pesquisa)).ToList();
            List<AlbumExibicaoViewModel> viewModels = Mapper.Map<List<Album>, List<AlbumExibicaoViewModel>>(albums);
            return Json(viewModels, JsonRequestBehavior.AllowGet);
        }

        // GET: Albuns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = repositorioAlbuns.SelecionarPorId(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumExibicaoViewModel>(album));
        }

        // GET: Albuns/Create
        [Authorize(Roles = "ADMINISTRADOR")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Albuns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "ADMINISTRADOR")]
        public ActionResult Create([Bind(Include = "Id,Nome,Ano,Observacoes,Email")] AlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Album album = Mapper.Map<AlbumViewModel, Album>(viewModel);
                repositorioAlbuns.Inserir(album);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        // GET: Albuns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = repositorioAlbuns.SelecionarPorId(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumViewModel>(album));
        }

        // POST: Albuns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nome,Ano,Observacoes,Email")] AlbumViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Album album = Mapper.Map<AlbumViewModel, Album>(viewModel);
                repositorioAlbuns.Alterar(album);
                return RedirectToAction("Index");
            }
            return View(viewModel);
        }

        // GET: Albuns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Album album = repositorioAlbuns.SelecionarPorId(id.Value);
            if (album == null)
            {
                return HttpNotFound();
            }
            return View(Mapper.Map<Album, AlbumExibicaoViewModel>(album));
        }

        // POST: Albuns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            repositorioAlbuns.ExcluirPorId(id);
            return RedirectToAction("Index");
        }

    }
}
