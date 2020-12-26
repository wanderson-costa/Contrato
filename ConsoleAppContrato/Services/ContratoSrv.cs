using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Services
{
    class ContratoSrv
    {
        private IPagamentoSrv pagamentoSrv;
        public ContratoSrv(IPagamentoSrv servicoPagamento)
        {
            this.pagamentoSrv = servicoPagamento;
        }
        public void processarContrato(Contrato Contrato, int totalParcelas)
        {
        }
    }
}
