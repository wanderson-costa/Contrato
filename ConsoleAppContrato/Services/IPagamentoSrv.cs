namespace Services
{
    interface IPagamentoSrv
    {
        double taxaPagamento(double valor);
        double taxaJuros(double valor, int numeroParcela);
    }
}
