using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class AdministradorTest
{
    [Test]
    public void Administrador()
    {
        Usuario admin = new Usuario("1234567-5", "Esteban", "Mr.Quito@gmail.com");
        
        Assert.NotNull(admin); // Admin no null
        Assert.AreEqual(admin.ID, "1234567-5"); // 
        Assert.AreEqual(admin.Nombre, "Esteban"); // El nombre del Admin coincide con el ingresado
        Assert.AreEqual(admin.Email, "Mr.Quito@gmail.com"); // El email del admin coincide con el ingresado
        }
}