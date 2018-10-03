using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterfaces.Entities
{
    class Prestacao
    {
        public DateTime DataVencimento { get; set; }
        public double Montante { get; set; }

        public Prestacao(DateTime dataVencimento, double montante)
        {
            DataVencimento = dataVencimento;
            Montante = montante;
        }
    }
}
