using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassLibrary;
public class Trabajador: Cliente
{
    public Trabajador(string id, string nombre, string email,string cedula, int edad,string telefono) : base(id, nombre, email, cedula, edad, telefono) //Constructor de Trabajador, heredado de Cliente
    {
    }
}