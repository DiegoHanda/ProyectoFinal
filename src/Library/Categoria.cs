using System;
namespace ClassLibrary;

public class Categoria
{
    public string Nombre { get; }
    public Categoria(string nombre) //Constructor de Categoria
    {
        if (nombre.Length != 0)
        {
            this.Nombre = nombre;
        }
        else
        {
            throw new Exception("La categoria necesita un nombre");
        }
    }
}