using NUnit.Framework;
using ClassLibrary;
using System.Linq;
namespace Library.Tests;

[TestFixture]
public class OfertasManagerTest
{
    [Test]
    public void CrearOferta()
    {
        Categoria categoria = new Categoria("C#");

        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        OfertasManager.Instance.CrearOferta(categoria,ofertante, "C# programmer");

        Assert.NotNull(OfertasManager.Instance.Ofertas);// El metodo introduce correctamente la nueva oferta a la lista
    }

    [Test]
    public void RemoveOferta() // Test eliminar oferta
    {
        Categoria categoria = new Categoria("C#");

        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        OfertasManager.Instance.CrearOferta(categoria,ofertante, "C# programmer");

        Assert.NotNull(OfertasManager.Instance.Ofertas); // La oferta existe
        Oferta oferta = OfertasManager.Instance.Ofertas.Last();
        OfertasManager.Instance.RemoveOferta(oferta); // Eliminamos la oferta
        CollectionAssert.DoesNotContain(OfertasManager.Instance.Ofertas, oferta); // Testeamos que haya quedado eliminada
    }
    
    [Test]
    public void PorCategoria() // Test ofertas por categoria
    {
        Categoria categoria = new Categoria("C#");
        Categoria categoria2 = new Categoria("Ruby");

        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        OfertasManager.Instance.CrearOferta(categoria, ofertante, "C# with 3yrs experience");
        OfertasManager.Instance.CrearOferta(categoria2, ofertante, "Ruby with 3yrs experience");

        Assert.AreEqual(OfertasManager.Instance.Ofertas[0], OfertasManager.Instance.PorCategoria("C#")[0]); // Testeamos que nos haya traido la oferta esperada por categoria
    }
    
    [Test]
    public void PorReputacion() // Test ofertas por reputacion
    {
        Categoria categoria = new Categoria("C#");

        Trabajador ofertante2 = new Trabajador("482038-5","Johnt","MR@gmail.com", "456791-2", 39,"0954479");
        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");

        OfertasManager.Instance.CrearOferta(categoria, ofertante2, "C# with 3yrs experience");
        OfertasManager.Instance.CrearOferta(categoria, ofertante, "C# with 3yrs experience");

        Calificacion calificacion = new Calificacion(3, ofertante, ofertante2);
        Calificacion calificacion2 = new Calificacion(2, ofertante2, ofertante);


        Assert.AreEqual(OfertasManager.Instance.Ofertas[0].Ofertante, OfertasManager.Instance.PorReputacion()[0].Ofertante); // Testeamos que nos haya traido la oferta esperada por reputacion
    }
}