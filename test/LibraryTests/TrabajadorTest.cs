using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class TrabajadorTest
{
    [Test]
    public void Trabajador()
    {
        Trabajador trabajador = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
        
        Assert.NotNull(trabajador); // Contrato no null
        Assert.AreEqual(trabajador.ID, "4823038-5"); // El id del trabajador coincide con el ingresado
        Assert.AreEqual(trabajador.Nombre, "Johntra"); // El nombre del trabajador coincide con el ingresado
        Assert.AreEqual(trabajador.Email, "MR.Bolta@gmail.com"); // El email del trabajador coincide con el ingresado
        Assert.AreEqual(trabajador.Cedula, "4567891-2"); // La cedula del trabajador coincide con el ingresado
        Assert.AreEqual(trabajador.Edad, 39); // La edad del trabajador coincide con el ingresado
        Assert.AreEqual(trabajador.Telefono, "095284479"); // El telefono del trabajador coincide con el ingresado
    }
}