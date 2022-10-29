using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassLibrary;
public class Cliente : Usuario
{
    public string Cedula{get;}
    public int Edad {get; set;}
    public string Telefono {get; set;}
    public List<int> Calificaciones {get;}
    public float Promedio {get;}
    public Cliente(string id, string nombre, string email, string cedula, int edad, string telefono) :
        base(id, nombre, email)
    {
        List <int> Calificaciones = new List<int>();
        Promedio = Calificaciones.Average();
    }
    public virtual Calificacion CrearCalificacion(int valor, Cliente calificado)
    {
        Calificacion calificacion  = new Calificacion (valor, this, calificado);
        return calificacion;
    }
    public Calificacion ObtenerCalificacion()
    {

    }

}