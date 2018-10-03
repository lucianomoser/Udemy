using ExercicioFixacaoInterfaces.Entities;
using System.Globalization;
using System;

namespace ExercicioFixacaoInterfaces.Service
{
    class ServicoContrado
    {

        private IServicoPagamentoOneLine _servicoPagamento = null;

        public ServicoContrado(IServicoPagamentoOneLine servicoPagamento)
        {
            _servicoPagamento = servicoPagamento;
        }

        
        public void ProcessoContrato(Contratos contrato, int meses)
        {
            double valor;

            Console.WriteLine("Installments:");

            contrato.prestacao.Montante = contrato.totalValue / meses;

            for (int i = 1; i <= meses; i++)
            {
                valor = _servicoPagamento.Interesse(contrato.prestacao.Montante, i);
                contrato.prestacao.DataVencimento = contrato.prestacao.DataVencimento.AddMonths(+1); 
                Console.WriteLine(contrato.prestacao.DataVencimento + " - " + valor.ToString("F2", CultureInfo.InvariantCulture) );

            }
            
            
          
        }
    }
}
