using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Empleador:Usuario
{
    public string nombre;
    public string apellido;
    public intint ID;
    public ArrayList<int> coordenadas;
    public string CedulaIdentidad;
    public Empleador(string nombre, string apellido, int ID, ArrayList<int> coordenadas, string CedulaIdentidad)
    {
       this.nombre=nombre;
        this.apellido=apellido;
        this.ID=ID;
        this.coordenadas=coordenadas;
        this.cedulaIdentidad=cedulaIdentidad; 
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