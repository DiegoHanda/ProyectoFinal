using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class CategoriaManagerTest
{
    [Test]
    public void CrearCategoria()
    {
        CategoriasManager.Instance.CrearCategoria("C#");
        
        Assert.NotNull(CategoriasManager.Instance.Categorias[0]); // Instancia creada y agregada a la lista
        Assert.AreEqual("C#", CategoriasManager.Instance.Categorias[0].Nombre); // Instancia coincide con la categoria
    }
    
    [Test]
    public void RemoveCategoria()
    {
        CategoriasManager.Instance.RemoveCategoria(CategoriasManager.Instance.Categorias[0]); // Instancia removida
        Assert.IsEmpty(CategoriasManager.Instance.Categorias); // Instancia removida de la lista
    }
}

