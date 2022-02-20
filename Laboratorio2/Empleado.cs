using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio2
{
    internal class Empleado
    {
        //Propiedades de tipo privada
        private string nombre;
        private string identificador;
        private string asignacionDia;

        //Ingreso de datos desde el formulario por medio de variables
        public string Nombre { get; set; }
        public string Identificador { get; set; }
        public decimal AsignacionDia { get; set; }

    }
}
