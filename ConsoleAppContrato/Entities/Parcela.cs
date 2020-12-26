using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Parcela
    {
        public DateTime Data { get; set; }
        public double Valor { get; set; }

        public Parcela()
        {
        }

        public Parcela(DateTime data, double valor)
        {
            this.Data = data;
            this.Valor = valor;
        }
    }
}
