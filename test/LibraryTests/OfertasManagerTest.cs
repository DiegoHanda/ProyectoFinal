using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class OfertasManagerTest
{
    [Test]
    public void CrearOferta()
    {
        OfertasManager manager = new OfertasManager();

        Categoria categoria = new Categoria("C#");

        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        manager.CrearOferta(categoria,ofertante, "C# programmer");

        Assert.NotNull(manager.Ofertas);// El metodo introduce correctamente la nueva oferta a la lista
    }

    [Test]
    public void RemoveOferta() // Test eliminar oferta
    {
        OfertasManager manager = new OfertasManager();

        Categoria categoria = new Categoria("C#");

        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        Oferta oferta = new Oferta(categoria, ofertante, "C# with 3yrs exp");

        Assert.NotNull(manager.Ofertas); // La oferta existe
        manager.RemoveOferta(oferta); // Eliminamos la oferta
        Assert.IsEmpty(manager.Ofertas); // Chequeamos que la lista este vacia
    }
    
    [Test]
    public void PorCategoria() // Test ofertas por categoria
    {
        OfertasManager manager = new OfertasManager();

        Categoria categoria = new Categoria("C#");
        Categoria categoria2 = new Categoria("Ruby");

        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        manager.CrearOferta(categoria, ofertante, "C# with 3yrs experience");
        manager.CrearOferta(categoria2, ofertante, "Ruby with 3yrs experience");

        Assert.AreEqual(manager.Ofertas[0], manager.PorCategoria("C#")[0]); // Testeamos que nos haya traido la oferta esperada por categoria
    }
    
    [Test]
    public void PorReputacion() // Test ofertas por reputacion
    {
        OfertasManager manager = new OfertasManager();

        Categoria categoria = new Categoria("C#");

        Trabajador ofertante2 = new Trabajador("482038-5","Johnt","MR@gmail.com", "456791-2", 39,"0954479");
        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        manager.CrearOferta(categoria, ofertante2, "C# with 3yrs experience");
        manager.CrearOferta(categoria, ofertante, "C# with 3yrs experience");

        Calificacion calificacion = new Calificacion(3, ofertante, ofertante2);
        Calificacion calificacion2 = new Calificacion(2, ofertante2, ofertante);


        Assert.AreEqual(manager.Ofertas[0].Ofertante, manager.PorReputacion()[0].Ofertante); // Testeamos que nos haya traido la oferta esperada por reputacion
    }
}