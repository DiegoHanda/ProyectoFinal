using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassLibrary;
public class Cliente
{
    public string Cedula{get;}
    public int Edad {get; set;}
    public string Telefono {get; set;}
    public List Calificaciones {get;}
    public float Promedio {get;}
    public Cliente(string id, string nombre, string email, string cedula, int edad, string telefono)
    {
        base(id, nombre, email);        
        Cedula = cedula;
        Edad = edad;
        Telefono = telefono;
        List <int> Calificaciones = new List();
        Promedio = Calificaciones.Average();
    }
    public virtual Calificacion CrearCalificacion(int valor, string calificador, string calificado)
    {
        Calificacion calificacion  = new Calificacion (valor, calificador, calificado);
        return calificacion;
    }
    public Calificacion ObtenerCalificacion()
    {

    }

}