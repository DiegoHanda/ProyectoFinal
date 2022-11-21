using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassLibrary;
public class Cliente : Usuario              // En este lugar utilizamos herencia otra vez, volviendo a cumplir con el OCP
{
    public string Cedula{get;}
    public int Edad {get; set;}
    public string Telefono {get; set;}
    public List <Calificacion> Calificaciones = new List<Calificacion>();
    public List <int> Values = new List<int>();
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
        calificado.AddCalificacion(calificacion);
    }
    private void AddCalificacion(Calificacion calificacion) //Este método agrega la nueva calificacion a la lista de calificaciones y calcula el nuevo promedio
    {
        Calificaciones.Add(calificacion);
        Values.Add(calificacion.Value);
        Promedio = Values.Average();
    }
}