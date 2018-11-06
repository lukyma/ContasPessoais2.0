using ContasPessoais2._0.App.Interface;
using ContasPessoais2.Domain.Entities;
using ContasPessoais2.Domain.Entities.Validator.PessoaValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContasPessoais2._0.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IPessoaAppService _pessoaAppService;
        public ValuesController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            var teste = _pessoaAppService.Add(new Pessoa());
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
