using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class CalificacionTests
{
    [Test]
    public void Calificacion()
    {
        Trabajador ofertante = new Trabajador("4823038-5","Johntra","MR.Bolta@gmail.com", "4567891-2", 39,"095284479");
        Empleador empleador = new Empleador("78955548-9", "Luska", "Mr.Walker@gmail.com", "5464332-8", 45, "888427153");
        Calificacion calificacion = new Calificacion(3, empleador, ofertante);
        
        Assert.NotNull(calificacion); // Calificacion no null
        Assert.AreEqual(calificacion.Calificado, ofertante); // El calificado coincide con el ingresado
        Assert.AreEqual(calificacion.Calificador, empleador); // El calificador coincide con el ingresado
    }
}