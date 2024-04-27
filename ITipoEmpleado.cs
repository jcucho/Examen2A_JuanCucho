using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
    public interface ITipoEmpleado
    {
        public double calcularSueldo(int numeroDias);
        public double calcularBonificacion(int numeroDias);
    }
}
