using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Trabajador: Usuario
{
    public Trabajador(string nombre, string email,int edad,string telefono,string contraseña,string cedula)
    {
        base(nombre, email, edad, telefono, contraseña, cedula);
    }

    public list ofertasPorCategoria()
    {

    }
    public list ofertasPorUbicacion()
    {

    }
    public list ofertasPorReputacion()
    {
        
    }
    public string crearOferta(string oferta,string categoria, ArrayList<int> coordenadas, string nombre)
    {
        Oferta oferta = new Oferta(categoria, coordenadas, nombre);
    }
}