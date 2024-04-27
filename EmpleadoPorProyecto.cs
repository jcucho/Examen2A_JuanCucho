using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
    public class EmpleadoPorProyecto : ITipoEmpleado
    {
        private double bonificacion_dia { get; set; } = 0.00;
        private double sueldo_dia_proyecto { get; set; } = 0.00;
        public double costo_proyecto { get; set; } = 0.00;
        public int dias_total_proyecto { get; set; } = 0;

        public double calcularBonificacion(int numeroDias)
        {
            return Math.Round(bonificacion_dia,2);
        }

        public double calcularSueldo(int numeroDias)
        {
            try
            {
                this.sueldo_dia_proyecto = (this.costo_proyecto / this.dias_total_proyecto);
                return Math.Round((this.sueldo_dia_proyecto * numeroDias),2);
            }
            catch (DivideByZeroException)
            {
                throw new Exception("Error de Sistema, No se puede divir entre cero");
            }
            catch (Exception)
            {
                throw new Exception("Error de Sistema, Contactar al Administrador");
            }

        }
    }
}
