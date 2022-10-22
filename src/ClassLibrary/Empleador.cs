using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Empleador:Usuario
{
    public string Nombre;
    public string Apellido;
    public intint ID;
    public ArrayList<int> Coordenadas;
    public string CedulaIdentidad;
    public Empleador(string Nombre, string Apellido, int ID, ArrayList<int> Coordenadas, string CedulaIdentidad)
    {
        Nombre=nombre;
        Apellido=apellido;
        ID=ID;
        Coordenadas=coordenadas;
        CedulaIdentidad=cedulaIdentidad; 
    }
    public List<string> OfertasPorCategoria() //Deberia tener una clase oferta Y una clase Ofertas que contenga la lista de Ofertas?
    {

    }

    public List<string> OfertasPorProximidad()
    {

    }
    public List<string> OfertasPorCalificacion()
    {
        
    }

    public void Calificar(int calificacion)
    {

    }

    public string Registrarse()
    {
        return ("Estas registrado");
    }

    public string GetInfoOferta(Oferta oferta)
    {
        
    }
}