using System;
using System.Collections.Generic;

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
            this.Parcela = new List<Parcela>();
        }

        public void adicionarParcela(Parcela parcela)
        {
            this.Parcela.Add(parcela);
        }
    }
}
