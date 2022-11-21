using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Empleador: Cliente
{
    public Empleador (string id, string nombre, string email, string cedula, int edad, string telefono) : base(id, nombre, email, cedula, edad, telefono) {} //Constructor de Empleador, heredado de Cliente
}