using System;
namespace ClassLibrary;

public class Categoria
{
    public string Nombre {get;}
    public Categoria (string nombre) //Constructor de Categoria
    {
        Check.Precondition(!string.IsNullOrEmpty(nombre));        // Aca estamos usando diseño por contrato. Chequeando una Precondición
        this.Nombre = nombre;
    }
}