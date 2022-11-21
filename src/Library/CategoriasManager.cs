using System;
using System.Collections.Generic;
namespace ClassLibrary;

public sealed class CategoriasManager
{
    private readonly static CategoriasManager _instance = new CategoriasManager(); // Singleton pattern
    private CategoriasManager() {}
    public static CategoriasManager Instance { get { return _instance; } }

    public List<Categoria> Lista=new List<Categoria>();

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
                        throw new Exception ("La categoria ya existe");
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
            throw new Exception ("La categoria no esta en la lista");
        }
    }
}
