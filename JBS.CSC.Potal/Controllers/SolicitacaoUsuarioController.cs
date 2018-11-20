using JBS.CSC.Potal.Models;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;

namespace JBS.CSC.Potal.Controllers
{
    public class SolicitacaoUsuarioController : Controller
    {
        #region Variaveis

        private readonly IUsuarioAppService _usuarioApp;
        private readonly ISistemaAppService _sistemaApp;
        private readonly ISolicitacaoAcessoAppService _solicitacaoAcessoApp;
        private string nomeUsuarioLogado;

        #endregion

        #region Contrutor

        public SolicitacaoUsuarioController(IUsuarioAppService usuarioApp, ISistemaAppService sistemaApp, ISolicitacaoAcessoAppService solicitacaoAcessoApp)
        {
            _usuarioApp = usuarioApp;
            _sistemaApp = sistemaApp;
            _solicitacaoAcessoApp = solicitacaoAcessoApp;
            nomeUsuarioLogado = System.Security.Principal.WindowsIdentity.GetCurrent().Name.Substring(10); ;
        }

        #endregion

        #region Metodos

        // GET: SolicitacaoUsuario
        public ActionResult Index()
        {
            return RedirectToAction("CriarSolicitacao");
        }

        // GET: SolicitacaoUsuario/Create
        public ActionResult CriarSolicitacao()
        {
            try
            {
                ViewBag.Usuario = Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioModel>>(_usuarioApp.GetAll()).Where(x => x.DesLoginUsuario.Equals(nomeUsuarioLogado)).FirstOrDefault();
                ViewBag.Sistema = Mapper.Map<IEnumerable<Sistema>, IEnumerable<SistemaModel>>(_sistemaApp.GetAll());
            }
            catch (Exception)
            {
                throw;
            }

            return View();
        }

        // POST: SolicitacaoUsuario/Create
        [HttpPost]
        public ActionResult CriarSolicitacao(SolicitacaoAcessoModel model)
        {
            var solicitacaoDomain = Mapper.Map<SolicitacaoAcessoModel, SolicitacaoAcesso>(model);
            solicitacaoDomain.LogDatSolicitacao = DateTime.Now;

            try
            {
                _solicitacaoAcessoApp.Add(solicitacaoDomain);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return View(model);
            }
        }

        // GET: SolicitacaoUsuario/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SolicitacaoUsuario/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SolicitacaoUsuario/Edit/5
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

        // GET: SolicitacaoUsuario/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SolicitacaoUsuario/Delete/5
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

        #endregion
    }
}
