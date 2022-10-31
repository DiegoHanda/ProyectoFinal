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
    public double Promedio {get; set;}
    public Cliente(string id, string nombre, string email, string cedula, int edad, string telefono) : base(id, nombre, email)
    {
        this.Cedula = cedula;
        this.Edad = edad;
        this.Telefono = telefono;
    }
    public void CrearCalificacion(int value, Cliente calificado) //Este método crea una instancia de Calificacion
    {
        Calificacion calificacion  = new Calificacion(value, this, calificado);
        calificado.AddCalificacion(value);
    }
    public void AddCalificacion(int value) //Este método agrega la nueva calificacion a la lista de calificaciones y calcula el nuevo promedio
    {
        Calificaciones.Add(value);
        Promedio = Calificaciones.Average();
    }
}