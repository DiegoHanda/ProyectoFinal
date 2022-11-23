using System;
using System.Linq;
using System.Collections.Generic;
namespace ClassLibrary;

public sealed class CategoriasManager
{
    private readonly static CategoriasManager _instance = new CategoriasManager(); // Aca se usa un singleton para que esta clase solo pueda ser instanciada una vez
    private CategoriasManager() {}
                                        //Intentamos mantener un bajo acoplamiento de las clases al evitar todo lo posible que esten relacionadas
                                        //Intentamos mantener la coherencia dentro de las clases sin aumentar su acoplamiento. 
    public static CategoriasManager Instance { get { return _instance; } }
    public List<Categoria> Categorias = new List<Categoria>();
    public void CrearCategoria(string nombre) //Este método crea una instancia de Categoria
    {
        Categoria categoria = new Categoria(nombre);
        Categorias.Add(categoria);
    }

    public void RemoveCategoria(Categoria categoria) //Este metodo elimina una categoria de la lista de categorias
    {
        Check.Precondition(Categorias.Contains(categoria));//Chequeamos precondiciones segun diseo por contrato
        Categorias.RemoveAll(x => x == categoria);
        
    }
}
