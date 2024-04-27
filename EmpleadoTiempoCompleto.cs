using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2A
{
    public class EmpleadoTiempoCompleto : ITipoEmpleado
    {
        public double sueldo_dia { get; set; } = 0.00;
        private int maximoNumeroDiasPermitidosTrabajados { get; set; } = 28;
        private double bonificacion { get; set; } = 0.00;

        public double calcularBonificacion(int numeroDias)
        {
            try
            {
                if (numeroDias > this.maximoNumeroDiasPermitidosTrabajados)
                    this.bonificacion = (numeroDias - this.maximoNumeroDiasPermitidosTrabajados) * this.sueldo_dia;
                return Math.Round(this.bonificacion,2);
            }
            catch (Exception)
            {
                throw new Exception("Error de Sistema, Contactar al Administrador");
            }
        }

        public double calcularSueldo(int numeroDias)
        {
            try
            {
                return Math.Round((this.sueldo_dia * numeroDias),2);
            }
            catch (Exception)
            {
                throw new Exception("Error de Sistema, Contactar al Administrador");
            }
        }
    }
}
