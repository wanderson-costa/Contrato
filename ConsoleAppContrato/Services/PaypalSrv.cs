namespace Services
{
    class PaypalSrv : IPagamentoSrv
    {
        private const double taxa = 0.02;
        private const double juros = 0.01;

        double IPagamentoSrv.taxaPagamento(double valor)
        {
            return (valor * taxa);
        }

        double IPagamentoSrv.taxaJuros(double valor, int numeroParcela)
        {
            return ((valor * juros) * numeroParcela);
        }
    }
}
