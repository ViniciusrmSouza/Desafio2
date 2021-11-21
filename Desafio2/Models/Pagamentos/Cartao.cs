using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models.Pagamentos
{
    public class Cartao
    {
        public string Titular { get; set; }
        public string Numero { get; set; }
        public string Data_Expiracao { get; set; }
        public string Bandeira { get; set; }
        public string Cvv { get; set; }
    }
}
