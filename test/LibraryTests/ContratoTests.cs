using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class ContratoTests
{
    [Test]
    public void Contrato()
    {
        Categoria categoria = new Categoria("C#");
        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
        Oferta oferta = new Oferta(categoria, ofertante, "C# with 3yrs exp");

        Empleador empleador = new Empleador("78955548-9", "Luska", "Mr.Walker@gmail.com", "5464332-8", 45, "888427153");
        Contrato contrato = new Contrato(oferta, empleador);
        
        Assert.NotNull(contrato); // Instancia create
        Assert.AreEqual(contrato.Oferta, oferta); // Getter de oferta
        Assert.AreEqual(contrato.Empleador, empleador); // Getter de empleador
    }
}