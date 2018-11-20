using Newtonsoft.Json;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace ProjetoModeloDDD.Services.WebApi.Controllers
{
    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        private UsuarioRepository _usuarioRepository = new UsuarioRepository();
        private ClienteDominioRepository _clienteDominioRepository = new ClienteDominioRepository();

        [Route("v1/ObterUsuarioLista/")]
        [HttpGet]
        public HttpResponseMessage ObterListaUsuario()
        {
            try
            {
                var lista = _usuarioRepository.ObterUsuariosLista();
                return Request.CreateResponse(HttpStatusCode.OK, lista);
            }
            catch (HttpException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [Route("v1/ObterUsuarioId/{id}")]
        [HttpGet]
        public HttpResponseMessage ObterUsuarioId(int id)
        {
            try
            {
                var usuario = _usuarioRepository.ObterUsuariosId(id);
                return Request.CreateResponse(HttpStatusCode.OK, usuario);
            }
            catch (HttpException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex.Message);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [Route("v1/IncluirUsuario")]
        [HttpPost]
        public HttpResponseMessage IncluirUsuario(UsuarioDomain usuario)
        {
            try
            {
                var posicao = usuario.Email.IndexOf("@") + 1;
                var clienteId =_clienteDominioRepository.ObterClienteDominio(usuario.Email.Substring(posicao));
                usuario.Client_id = clienteId == null ? _clienteDominioRepository.ObterClienteDominio("siriusapp.com.br").Client_id : clienteId.Client_id;
                usuario.Created_at = DateTime.Now;
                usuario.Updated_at = DateTime.Now;
                usuario.Active = true;
                usuario.Plan = "Free";
                _usuarioRepository.IncluirUsuarios(usuario);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (HttpException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [Route("v1/AlterarUsuario/{id}")]
        [HttpPut]
        public HttpResponseMessage AlterarUsuario(int id, UsuarioDomain usuario)
        {
            try
            {
                _usuarioRepository.AlterarUsuarios(id, usuario);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (HttpException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [Route("v1/RemoverUsuariosId/{id}")]
        [HttpDelete]
        public HttpResponseMessage RemoverUsuariosId(int id)
        {
            try
            {
                _usuarioRepository.RemoverUsuariosId(id);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (HttpException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }

        [Route("v1/TrocarSenha")]
        [HttpPost]
        public HttpResponseMessage TrocarSenha(UsuarioDomain usuario)
        {
            try
            {
                _usuarioRepository.TrocarSenha(usuario.Email);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (HttpException ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, ex);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex);
            }
        }
    }
}