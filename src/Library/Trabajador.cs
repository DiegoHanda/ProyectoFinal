using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary;
public class Trabajador: Cliente
{
    public Trabajador(string ID, string nombre, string email,string cedula, int edad,string telefono)
    {
        base(id, nombre, email, cedula, edad, telefono);
    }
    // public override Calificacion CrearCalificacion(int valor, Empleador calificado)
    // {
    //     return base.CrearCalificacion(valor, Nombre, calificado);
    // }
}