using System;
using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary;
public class Usuario
{
    public string Nombre {get; set;}
    public string Email {get; set;}
    public string ID {get;}
    public string Cedula{get;}
    public Usuario(string nombre, string email, string ID)
    {
        this.Nombre = nombre;
        this.Email = email;
        this.Edad = edad;
        this.ID=ID;
    }
    

    
}