using System;
using System.Globalization;

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

        public override string ToString()
        {
            return Data.ToString("dd/MM/yyyy") +
                   " - " +
                   Valor.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
