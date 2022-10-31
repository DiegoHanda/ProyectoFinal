using System;

namespace ClassLibrary;
public class Usuario
{
    public string ID {get;}
    public string Nombre {get; set;}
    public string Email {get; set;}
    public Usuario(string id, string nombre, string email) //Constructor de Usuario
    {
        this.ID = id;
        this.Nombre = nombre;
        this.Email = email; 
    }
}
