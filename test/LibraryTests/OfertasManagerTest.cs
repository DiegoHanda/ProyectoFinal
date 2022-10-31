using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class OfertasManagerTest
{
    [Test]
    public void OfertasManager()
    {
        OfertasManager manager = new OfertasManager();
        Categoria categoria = new Categoria("C#");
        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
        Oferta oferta = new Oferta(categoria, ofertante, "C# with 3yrs exp");
        manager.CrearOferta(categoria,ofertante, "Hola, esto es un texto de prueba.");

        Assert.NotNull(manager); // Manager not null
        Assert.NotNull(categoria);//Se verifica que se hayan creado las variables correctamente
        Assert.NotNull(ofertante);
        Assert.NotNull(oferta);
        Assert.Contains(oferta, manager.Lista);// El metodo introduce correctamente la nueva oferta a la lista
    }
}