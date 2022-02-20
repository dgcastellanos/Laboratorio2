using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Nomina
    {
        //Propiedades de tipo privado
        private int diasLaborados;

        //Ingreso de datos
        public int DiasLaborados { get; set; }

        //Métodos para el cálculo de nómina
        public decimal CalculoNomina(int diasLaborados, decimal valorDia)
        {
            decimal totalSalario = (valorDia * diasLaborados);

            return totalSalario;
        }
    }
}
