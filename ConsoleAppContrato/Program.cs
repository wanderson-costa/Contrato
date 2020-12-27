using System;
using System.Globalization;
using Entities;
using Services;

namespace ConsoleAppContrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira os dados do contrato");
            Console.Write("Número:");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/aaaa):");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Insira o número de parcelas:");
            int numeroParcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            ContratoSrv contratoSrv = new ContratoSrv(new PaypalSrv());
            contratoSrv.processarContrato(contrato, numeroParcelas);

            Console.WriteLine("Parcelas: ");
            foreach (Parcela parcela in contrato.Parcela)
            {
                Console.WriteLine(parcela);
            }
            Console.ReadLine();
        }
    }
}
