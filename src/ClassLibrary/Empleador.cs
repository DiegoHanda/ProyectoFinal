using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Empleador: Cliente
{
    public ArrayList<int> Coordenadas;
    public Empleador (string id, string nombre, string email, string contraseña, int edad, string telefono, string cedula)
    {
        base(id, nombre, email, cedula, edad, telefono);
    }
    public override Calificacion CrearCalificacion(int valor, Trabajador calificado)
    {
        return base.CrearCalificacion(valor, calificado, Nombre);
    }    
}