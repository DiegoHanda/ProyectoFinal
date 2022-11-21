using System;
namespace ClassLibrary;

public class Categoria
{
    public string Nombre {get;}
    public Categoria (string nombre) //Constructor de Categoria
    {
        if (String.IsNullOrEmpty(nombre))
        {
            throw new Exception ("El nombre de la categoria no es válido");
        }
        else
        {
            this.Nombre = nombre;
        }
    }
}