using ProjetoModeloDDD.Infra.Data.Repositories;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var activeAdminCommentsRepository = new ActiveAdminCommentsRepository();
            var adminUserRepository = new AdminUserRepository();
            var authorizationsReposiroy = new AuthorizationsReposiroy();
            var clienteDominioRepository = new ClienteDominioRepository();
            var clienteRepository = new ClienteRepository();
            var groupsRepository = new GroupsRepository();
            var grupoUsuarioRepository = new GrupoUsuarioRepository();
            var mensagemRepository = new MensagemRepository();
            var schemaMigrationsRepository = new SchemaMigrationsRepository();
            var usuarioRepository = new UsuarioRepository();
            var wordAlertsRepository = new WordAlertsRepository();

            var listaactiveAdminCommentsRepository = activeAdminCommentsRepository.ObterActiveAdminComentsLista();
            var listaadminUserRepository = adminUserRepository.ObterAdminUserLista();
            var listaauthorizationsReposiroy = authorizationsReposiroy.ObterAutorizationsLista();
            var listaclienteDominioRepository = clienteDominioRepository.ObterClienteDomainLista();
            var listaclienteRepository = clienteRepository.ObterClienteLista();
            var listagroupsRepository = groupsRepository.ObterGroupsLista();
            var listagrupoUsuarioRepository = grupoUsuarioRepository.ObterGrupoUsuarioDomainLista();
            var listamensagemRepository = mensagemRepository.ObterMensagemLista();
            var listaschemaMigrationsRepository = schemaMigrationsRepository.ObterSchemaMigrationsLista();
            var listausuarioRepository = usuarioRepository.ObterUsuariosLista();
            var listawordAlertsRepository = wordAlertsRepository.ObterWordAlertsLista();

            return View();
        }
    }
}