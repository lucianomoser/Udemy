using System;
using ExercicioFixacaoInterfaces.Entities;
using ExercicioFixacaoInterfaces.Service;


namespace ExercicioFixacaoInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter contract data");
                Console.Write("Number: ");

                int numero = int.Parse(Console.ReadLine());
                Console.Write("Date (dd/MM/yyyy): ");

                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Contract value: ");
                double ValorContrato = Double.Parse(Console.ReadLine());

                Console.Write("Enter number of installments: ");
                int QtdadeMeses = int.Parse(Console.ReadLine());

                Contratos contratos = new Contratos(numero, data, ValorContrato, new Prestacao(data, ValorContrato));

                ServicoContrado servicoContrado = new ServicoContrado(new ServicoPayPal());

                servicoContrado.ProcessoContrato(contratos, QtdadeMeses);

                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu um erro na inesperado. " + e.Message);
                Console.ReadKey();
            }
        }
    }
}
