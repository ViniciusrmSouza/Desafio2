using Desafio2.Models.Pagamentos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Controllers
{
    [Route("api/pagamento/[controller]")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        [HttpPost]
        public Situacao Comprar([FromBody] Compras compras)
        {
            Situacao situacao;

            if (compras.Valor <= 100)
            {
                return situacao = new Situacao("Rejeitado", compras.Valor);
            }
            else
            {
                return situacao = new Situacao("Aprovado", compras.Valor);
            }
        }
    }
}
