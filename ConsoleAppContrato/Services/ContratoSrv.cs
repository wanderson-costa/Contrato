using System;
using Entities;

namespace Services
{
    class ContratoSrv
    {
        private IPagamentoSrv pagamentoSrv;
        public ContratoSrv(IPagamentoSrv servicoPagamento)
        {
            pagamentoSrv = servicoPagamento;
        }
        public void processarContrato(Contrato contrato, int numeroParcelas)
        {
            double valorParcela = (contrato.Valor / numeroParcelas);

            for (int i = 1; i <= numeroParcelas; i++)
            {
                DateTime dataParcela = contrato.Data.AddMonths(i);

                double jurosParcela = pagamentoSrv.taxaJuros(valorParcela, i);
                double taxaParcela = pagamentoSrv.taxaPagamento(valorParcela + jurosParcela);
                double valorTotal = (valorParcela + jurosParcela + taxaParcela);

                contrato.adicionarParcela(new Parcela(dataParcela, valorTotal));
            }
        }
    }
}
