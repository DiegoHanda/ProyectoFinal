using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class UsuarioTest
{
    [Test]
    public void Usuario()
    {
        Usuario usuario = new Usuario("123", "Ejemplo", "ejemplo@gmail.com");

        Assert.NotNull(usuario); // Usuario no null
        Assert.AreEqual(usuario.ID, "123"); // El id coincide con el ingresado
        Assert.AreEqual(usuario.Nombre, "Ejemplo"); // El nombre coincide con el ingresado
        Assert.AreEqual(usuario.Email, "ejemplo@gmail.com"); // El email coincide con el ingresado
    }
}