using Examen2A;
try
{
    Console.WriteLine("Empleado a tiempo completo");
    Console.WriteLine("==========================");
    GestorRecursosHumanos empleadoTiempoCompleto = new GestorRecursosHumanos(new EmpleadoTiempoCompleto { sueldo_dia = 80.00 });
    empleadoTiempoCompleto.calcularPagos(numeroDias: 31);
    Console.WriteLine();

    Console.WriteLine("Empleado por proyecto");
    Console.WriteLine("==========================");
    GestorRecursosHumanos empleadoPorProyecto = new GestorRecursosHumanos(new EmpleadoPorProyecto { costo_proyecto = 15000.00, dias_total_proyecto = 90 });
    empleadoPorProyecto.calcularPagos(numeroDias: 25);
    Console.ReadLine();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());   
}
