using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models.Pagamentos
{
    public class Compras
    {
        public Guid  Id { get; set; }
        public double Valor { get; set; }
        public Cartao Cartao { get; set; }
    }
}
