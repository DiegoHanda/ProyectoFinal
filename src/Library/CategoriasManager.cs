using System;
using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary;

public sealed class CategoriasManager
{
    private readonly static CategoriasManager _instance = new CategoriasManager(); // Singleton pattern
    private CategoriasManager() {}
                                        //Intentamos mantener un bajo acoplamiento de las clases al evitar todo lo posible que esten relacionadas
                                        //La mayoria de nuestras clases no dependen de otras
                                        //Intentamos mantener la coherencia dentro de las clases sin aumentar su acoplamiento
    public static CategoriasManager Instance { get { return _instance; } }
    public List<Categoria> Categorias = new List<Categoria>();
    public void CrearCategoria(string nombre) //Este método crea una instancia de Categoria
    {
        Categoria categoria = new Categoria(nombre);
        Categorias.Add(categoria);
    }

    public void RemoveCategoria(Categoria categoria)
    {
        if (Categorias.Contains(categoria)) {
            Categorias.RemoveAll(x => x == categoria);
        }
    }
}
