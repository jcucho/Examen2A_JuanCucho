using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
    public class GestorRecursosHumanos
    {
        private readonly ITipoEmpleado _ITipoEmpleado;

        public GestorRecursosHumanos(ITipoEmpleado tipoEmpleado)
        {
            this._ITipoEmpleado = tipoEmpleado;
        }

        public void calcularPagos(int numeroDias)
        {
            Console.WriteLine("El sueldo es de:" + string.Format("{0:C}", _ITipoEmpleado.calcularSueldo(numeroDias)));
            Console.WriteLine("la bonificacion es de:" + string.Format("{0:C}", _ITipoEmpleado.calcularBonificacion(numeroDias)));
        }
    }
}
