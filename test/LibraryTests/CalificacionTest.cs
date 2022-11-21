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

        Calificacion calificacion = new Calificacion(3, empleador, ofertante); // Creamos una nueva calificacion
        
        Assert.NotNull(calificacion); // Instancia creada
        Assert.AreEqual(calificacion.Value, 3); // Getter de Value
        Assert.AreEqual(calificacion.Calificado, ofertante); // Getter de Calificado
        Assert.AreEqual(calificacion.Calificador, empleador); // Getter de Calificador
    }
}