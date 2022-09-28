using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Trabajador: Usuario
{
    public Trabajador(string nombre, string email,int edad,string telefono,string contraseña,string cedula)
    {
        base(nombre, email, edad, telefono, contraseña, cedula);
    }

    ofertasPorCategoria()
    ofertasPorUbicacion()
    ofertasPorReputacion()
}