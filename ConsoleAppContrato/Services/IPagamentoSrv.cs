using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    interface IPagamentoSrv
    {
        double taxaPagamento(double valor);
        double taxaJuros(double valor, int numeroParcela);
    }
}
