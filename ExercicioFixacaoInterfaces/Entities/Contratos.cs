using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoInterfaces.Entities
{
    class Contratos
    {
        public int number { get; set; }
        public DateTime date { get; set; }
        public double totalValue { get; set; }
        public Prestacao prestacao { get; set; }

        public Contratos(int number, DateTime date, double totalValue, Prestacao prestacao)
        {
            this.number = number;
            this.date = date;
            this.totalValue = totalValue;
            this.prestacao = prestacao;
        }

       

    }
}
