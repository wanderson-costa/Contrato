using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Contrato
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double Valor { get; set; }
        public List<Parcela> Parcela { get; set; }

        public Contrato()
        {
        }

        public Contrato(int numero, DateTime data, double valor)
        {
            this.Numero = numero;
            this.Data = data;
            this.Valor = valor;
            this.Parcela = null;
        }
    }
}
