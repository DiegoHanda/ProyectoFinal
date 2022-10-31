using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class ContratosManagerTest
{
    [Test]
    public void CrearContrato()
    {
        Categoria categoria = new Categoria("C#");
        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
        Oferta oferta = new Oferta(categoria, ofertante, "C# with 3yrs exp");

        Empleador empleador = new Empleador("78955548-9", "Luska", "Mr.Walker@gmail.com", "5464332-8", 45, "888427153");
        ContratosManager contrato = new ContratosManager();
        
        // Creamos un contrato desde ContratosManager
        contrato.CrearContrato(oferta, empleador);
        Assert.NotNull(contrato); // Contrato no null
        Assert.AreEqual(contrato.contratoCreado.Oferta, oferta); // La oferta del contrato coincide con la oferta ingresada
        Assert.AreEqual(contrato.empleadorCreado, empleador); // El empleador del contrato coincide con el empleador ingresado
    }
}