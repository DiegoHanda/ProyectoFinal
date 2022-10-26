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
    public Empleador(string nombre, string apellido, int id, ArrayList<int> coordenadas, string cedulaIdentidad)//Cambio la super clase, hay que cambiar el base para que quede igual (Ver Administrador)
    {
        this.Nombre=nombre;
        this.Apellido=apellido;
        this.ID=id;
        this.Coordenadas=coordenadas;
        this.CedulaIdentidad=cedulaIdentidad; 
    }
    public List<string> OfertasPorCategoria() //Deberia tener una clase oferta Y una clase Ofertas que contenga la lista de Ofertas?
    {

    }

    public List<string> OfertasPorProximidad()//Estas cosas van en el manager
    {

    }
    public List<string> OfertasPorCalificacion()//Estas cosas van en sus manager
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