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
        
        ContratosManager.Instance.CrearContrato(oferta, empleador); // Creamos una instancia

        Assert.NotNull(ContratosManager.Instance.Contratos[0]); // Instancia creada
        Assert.AreEqual(ContratosManager.Instance.Contratos[0].Oferta, oferta); // Getter de Oferta
        Assert.AreEqual(ContratosManager.Instance.Contratos[0].Empleador, empleador); // Getter de empleador
    }
    
    public void RemoveContrato()
    {
        ContratosManager.Instance.RemoveContrato(ContratosManager.Instance.Contratos[0]); // Instancia removida
        Assert.IsEmpty(ContratosManager.Instance.Contratos); // Instancia removida de la lista
    }
}