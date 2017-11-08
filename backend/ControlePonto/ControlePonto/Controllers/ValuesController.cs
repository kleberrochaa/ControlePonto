using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ControlePonto.Controllers
{


    public class Pessoa
    {
        public string Nome { get; set; }
        public int idade { get; set; }

    }

    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<object> Geti(int idade)
        {

            List<object> PessoasPorIdade = new List<object>();

            Pessoa Pessoa1 = new Pessoa
            {
                Nome = "Kleber",
                idade =  23

            };

            Pessoa Pessoa2 = new Pessoa
            {
                Nome = "Rocha",
                idade = 28

            };

            Pessoa Pessoa3 = new Pessoa
            {
                Nome = "Rocha2",
                idade = 35

            };



            if(Pessoa1.idade > idade)
            {
                PessoasPorIdade.Add(Pessoa1);
            }

            if (Pessoa2.idade > idade)
            {
                PessoasPorIdade.Add(Pessoa2);
            }

            if (Pessoa3.idade > idade)
            {
                PessoasPorIdade.Add(Pessoa3);
            }



            return PessoasPorIdade;
            ;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
