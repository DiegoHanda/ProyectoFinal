using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class CategoriaManagerTest
{
    [Test]
    public void Categoria()
    {
        CategoriasManager man1 = new CategoriasManager();
        Categoria categoria = new Categoria("Limpieza");
        man1.AddCategoria(categoria);


        
        Assert.NotNull(categoria); // Verificacion de que la categoria este siendo creada adecuadamente
        Assert.NotNull(man1); // Verificando que el manager se haya creado correctamente
        Assert.Contains(categoria, man1.Lista);//El metodo introduce correctamente la categoria a la lista
    }
}