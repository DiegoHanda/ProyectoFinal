using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary;
public class Trabajador: Cliente
{
    public Trabajador(string nombre, string email,int edad,string telefono,string contraseña,string cedula)//Cambio la super clase, hay que cambiar el base para que quede igual (Ver Administrador)
    {
        base(id, nombre, email, cedula, edad, telefono);
    }
    public override Calificacion CrearCalificacion(int valor, Empleador calificado)
    {
        return base.CrearCalificacion(valor, Nombre, calificado);
    }
}