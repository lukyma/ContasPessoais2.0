using ContasPessoais2._0.App.Interface;
using ContasPessoais2.Domain.Entities;
using ContasPessoais2.Domain.Entities.Validator.PessoaValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ContasPessoais2._0.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPessoaAppService _pessoaAppService;
        public HomeController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }
        public ActionResult Index()
        {
            _pessoaAppService.Add(new Pessoa());
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
