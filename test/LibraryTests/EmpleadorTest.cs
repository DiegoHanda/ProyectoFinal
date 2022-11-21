using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class EmpleadorTest
{
    [Test]
    public void Empleador()
    {
        Empleador empleador = new Empleador("78955548-9", "Luska", "Mr.Walker@gmail.com", "5464332-8", 45, "888427153");
        
        Assert.NotNull(empleador); // Contrato no null
        Assert.AreEqual(empleador.ID, "78955548-9"); // Getter de ID
        Assert.AreEqual(empleador.Nombre, "Luska"); // Getter de Nombre
        Assert.AreEqual(empleador.Email, "Mr.Walker@gmail.com"); // Getter de Email
        Assert.AreEqual(empleador.Cedula, "5464332-8"); // Getter de Cedula
        Assert.AreEqual(empleador.Edad, 45); // Getter de Edad
        Assert.AreEqual(empleador.Telefono, "888427153"); // Getter de Telefono
    }
}