using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Empleador: Cliente
{
    public Empleador (string id, string nombre, string email, string cedula, int edad, string telefono) :
        base(id, nombre, email, cedula, edad, telefono)
    {
       
    }
    // public override Calificacion CrearCalificacion(int valor, Trabajador calificado)
    // {
    //     return base.CrearCalificacion(valor, calificado.Nombre, this.Nombre);
    // }    
}