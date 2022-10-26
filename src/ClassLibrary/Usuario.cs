using System;
using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary;
public class Usuario
{
    public string Nombre {get; set;}
    public string Email {get; set;}
    public int Edad {get; set;}
    public string Telefono {get; set;}
    public string ID {get;}
    public string Cedula{get;}
    public List Calificaciones {get; set;}
    public float Promedio {get; set;}
    public Usuario(string nombre, string email, int edad, string telefono, string contraseña, string cedula)
    {
        this.Nombre = nombre;
        this.Email = email;
        this.Edad = edad;
        this.Telefono = telefono;
        this.Contraseña = contraseña;    
        this.Cedula = cedula;
        List <int> Calificaciones = new List();
        this.Promedio=Calificaciones.Average();
    }
    

    
}