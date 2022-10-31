using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class CategoriaTests
{
    [Test]
    public void Categoria()
    {
        Categoria categoria = new Categoria("Jardineria");

        Assert.NotNull(categoria); // Categoria no Null
        Assert.AreEqual(categoria.Nombre, "Jardineria" ); // Nombre de la categoria coincide con el string esperado
    }
}