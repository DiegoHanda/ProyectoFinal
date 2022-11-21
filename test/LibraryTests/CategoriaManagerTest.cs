using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class CategoriaManagerTest
{
    [Test]
    public void AddCategoria()
    {
        Categoria categoria = new Categoria("Limpieza");
        CategoriasManager.Instance.AddCategoria(categoria);


        
        Assert.NotNull(categoria); // Verificacion de que la categoria este siendo creada adecuadamente
        Assert.NotNull(CategoriasManager.Instance); // Verificando que el manager se haya creado correctamente
        Assert.Contains(categoria, CategoriasManager.Instance.Lista);//El metodo introduce correctamente la categoria a la lista

        CategoriasManager.Instance.RemoveCategoria(categoria);

        Assert.IsEmpty(CategoriasManager.Instance.Lista);
    }
[Test]
    public void RemoveCategoria()
    {
        Categoria categoria = new Categoria("Limpieza");
        CategoriasManager.Instance.AddCategoria(categoria);


        
        Assert.NotNull(categoria); // Verificacion de que la categoria este siendo creada adecuadamente
        Assert.NotNull(CategoriasManager.Instance); // Verificando que el manager se haya creado correctamente
        Assert.Contains(categoria, CategoriasManager.Instance.Lista);//El metodo introduce correctamente la categoria a la lista

        CategoriasManager.Instance.RemoveCategoria(categoria);

        Assert.IsEmpty(CategoriasManager.Instance.Lista);
    }
}

