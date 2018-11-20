using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JBS.CSC.Potal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repositorio = new RepositoryBase<Usuario>();
            var result = repositorio.GetAll().Where(c=>c.CodUsuario == 4008).FirstOrDefault();

            result.ValStatusUsuario = 1;
            result.DatCadastroUsuario = DateTime.Now;

            repositorio.Update(result);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}