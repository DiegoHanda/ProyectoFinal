using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class CategoriasManager
{
    List<Categoria> Lista=new List<Categoria>();
    public CategoriasManager()
    {
    }

    public void AddCategoria(Categoria categoria)
    {
        if (categoria != null) //chequeo de precondicion nulo o vacio
         {
                if (!Lista.Contains(categoria))
                    {
                        this.Lista.Add(categoria);
                    }
                    else
                    {
                        Console.WriteLine("La categoria ya existe");
                    }
        }
        else
        {
            throw new Exception ("La categoria necesita un nombre");// Hay que hacer el try y catch despues
        }
    }

    public void RemoveCategoria(Categoria categoria)
    {
        if (this.Lista.Contains(categoria))
        {
            this.Lista.Remove(categoria);
        }
        else 
        {
            Console.WriteLine("La categoria no esta en la lista");
        }
    }
}
                //Hay que verificar que lo que se ingrese en string, no sea un string vacio

