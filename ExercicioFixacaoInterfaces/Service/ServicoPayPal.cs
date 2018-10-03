using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterfaces.Service
{
    class ServicoPayPal : IServicoPagamentoOneLine
    {
        public double Interesse(double montante, int meses)
        {
            const double JurosSimples = 1;
            double ValorTaxa;
            double ValorParcela = 0;

            try
            {                             

                ValorTaxa = (montante * JurosSimples / 100)* meses;

                ValorParcela = montante + ValorTaxa;

                ValorParcela = TaxaServicoPagamento(ValorParcela);               
                
                return ValorParcela;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("Erro no calculo do interesse. " + e.Message);
            }

        }

        public double TaxaServicoPagamento(double montante)
        {
            const double Taxa = 2;
            double ValorJuros = 0;

            try
            {
                ValorJuros = (montante * Taxa / 100);
                return montante + ValorJuros;
            }
            catch (Exception e)
            {
                throw new NotImplementedException("Erro no calculo da taxa de Serviço de Pagamento. " + e.Message);
            }
        }       

    }
}
