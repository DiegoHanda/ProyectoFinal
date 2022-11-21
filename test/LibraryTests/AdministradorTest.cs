using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class AdministradorTest
{
    [Test]
    public void Administrador()
    {
        Administrador admin = new Administrador("1234567-5", "Esteban", "Mr.Quito@gmail.com"); // Creamos un nuevo administrador
        
        Assert.NotNull(admin); // Instancia creada

        Assert.AreEqual(admin.ID, "1234567-5"); // Getter de Id
        Assert.AreEqual(admin.Nombre, "Esteban"); // Getter de Nombre
        Assert.AreEqual(admin.Email, "Mr.Quito@gmail.com"); // Getter de Email
        }
}