using System;
using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary;

public sealed class CategoriasManager
{
    private readonly static CategoriasManager _instance = new CategoriasManager(); // Singleton pattern
    private CategoriasManager() {}
    public static CategoriasManager Instance { get { return _instance; } }


    public List<Categoria> Lista=new List<Categoria>();                  //Intentamos mantener un bajo acoplamiento de las clases al evitar todo lo posible que esten relacionadas
    public void AddCategoria(Categoria categoria)                        //La mayoria de nuestras clases no dependen de otras
    {
        if (categoria != null) //chequeo de precondicion nulo o vacio
         {
                if (!Lista.Contains(categoria))
                    {                                                      //Intentamos mantener la coherencia dentro de las clases sin aumentar su acoplamiento
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
        if (Categorias.Contains(categoria)) {
            Categorias.RemoveAll(x => x == categoria);
        }
    }
}
