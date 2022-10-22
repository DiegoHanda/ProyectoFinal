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
    private string Contraseña;
    public string Cedula{get;}
    public List Calificaciones {get; set;}
    public float Promedio {get; set;}
    public Usuario(string nombre, string email, int edad, string telefono, string contraseña, string cedula)
    {
        Nombre = nombre;
        Email = email;
        Edad = edad;
        Telefono = telefono;
        Contraseña = contraseña;    
        Cedula = cedula;
        List <int> Calificaciones = new List();
        Promedio=Calificaciones.Average();
    }
    public void enviarMensaje(string mensaje, Usuario usuario)
    {   
        usuario.recibirMensaje(mensaje, nombre);
    }
    public string recibirMensaje(string mensaje, string nombre)
    {
        return $"{nombre}, le ha enviado el siguiente mensaje: {mensaje}";
    }

    
}