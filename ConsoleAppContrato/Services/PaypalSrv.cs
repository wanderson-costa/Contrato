using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class PaypalSrv : IPagamentoSrv
    {
        double IPagamentoSrv.taxaPagamento(double valor)
        {
            throw new NotImplementedException();
        }

        double IPagamentoSrv.taxaJuros(double valor, int numeroParcela)
        {
            throw new NotImplementedException();
        }
    }
}
