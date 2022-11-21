using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class ClienteTest
{
    [Test]
    public void Cliente()
    {
        Cliente cliente = new Cliente("78955548-9", "Luska", "Mr.Walker@gmail.com", "5464332-8", 45, "888427153");
        Cliente cliente2 = new Cliente("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
        
        Assert.NotNull(cliente); // Cliente no null
        Assert.AreEqual(cliente.ID, "78955548-9"); // El id del cliente coincide con el ingresado
        Assert.AreEqual(cliente.Nombre, "Luska"); // El nombre del cliente coincide con el ingresado
        Assert.AreEqual(cliente.Email, "Mr.Walker@gmail.com"); // El email del cliente coincide con el ingresado
        Assert.AreEqual(cliente.Cedula, "5464332-8"); // La cedula del cliente coincide con el ingresado
        Assert.AreEqual(cliente.Edad, 45); // La edad del cliente coincide con el ingresado
        Assert.AreEqual(cliente.Telefono, "888427153"); // El telefono del cliente coincide con el ingresado
        

        cliente.CrearCalificacion(3, cliente2); // Creamos una Calificacion desde Cliente
        
        Assert.AreEqual(cliente2.Promedio, 3); // La oferta del contrato coincide con la oferta ingresada
        Assert.AreEqual(cliente2.Calificaciones[0].Value, 3); // El cliente del contrato coincide con el cliente ingresado
    }
}