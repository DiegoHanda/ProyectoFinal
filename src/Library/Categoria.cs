using System;
namespace ClassLibrary;

public class Categoria
{
    public string Nombre {get;}
    public Categoria (string nombre) //Constructor de Categoria
    {
        if (Nombre == "")
        {
            throw new Exception ($"El nombre de la categoria no puede ser vacío");
        }
        else
        {
            this.Nombre = nombre;
        }
    }
}