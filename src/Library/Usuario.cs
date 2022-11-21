using System;

namespace ClassLibrary;
public class Usuario
{
    public string ID {get;}              //Para reutilizar codigo, creamos una clase padre Usuario, de la cual heredan administrador y Cliente. De esta forma solo tenemos que
    public string Nombre {get; set;}     //escribir esta parte del codigo una vez, y agregarle las cosas especificas a cada heredero.
    public string Email {get; set;}     //Ademas de esto, al utilizar herencia cumplimos con el OCP, ya que las clases estaran abiertas a la extensión pero cerradas a la modificación
    public Usuario(string id, string nombre, string email) //Constructor de Usuario
    {
        this.ID = id;
        this.Nombre = nombre;
        this.Email = email; 
    }
}
