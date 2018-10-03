using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterfaces.Service
{
    interface IServicoPagamentoOneLine
    {
        double TaxaServicoPagamento(double montante);
        double Interesse(double montante, int meses);        
    }
}
