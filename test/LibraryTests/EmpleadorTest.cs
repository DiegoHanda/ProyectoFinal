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
        Assert.AreEqual(empleador.ID, "78955548-9"); // El id del Empleador coincide con el ingresado
        Assert.AreEqual(empleador.Nombre, "Luska"); // El nombre del Empleador coincide con el ingresado
        Assert.AreEqual(empleador.Email, "Mr.Walker@gmail.com"); // El email del Empleador coincide con el ingresado
        Assert.AreEqual(empleador.Cedula, "5464332-8"); // La cedula del Empleador coincide con el ingresado
        Assert.AreEqual(empleador.Edad, 45); // La edad del Empleador coincide con el ingresado
        Assert.AreEqual(empleador.Telefono, "888427153"); // El telefono del Empleador coincide con el ingresado
    }
}