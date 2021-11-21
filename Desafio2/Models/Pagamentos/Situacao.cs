using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio2.Models.Pagamentos
{
    public class Situacao
    {
        public string Estado { get; set; }
        public double Valor { get; set; }

        public Situacao(string estado, double valor)
        {
            Estado = estado;
            Valor = valor;
        }
    }
}
