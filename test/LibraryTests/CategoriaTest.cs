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

        Assert.NotNull(categoria); // Instancia creada
        Assert.AreEqual(categoria.Nombre, "Jardineria" ); // Getter de Nombre
    }
}