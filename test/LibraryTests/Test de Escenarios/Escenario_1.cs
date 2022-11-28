using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class Escenario_1
{//En este escenario, se crea una categoria, un trabajador se da cuenta que puede hacer una oferta con la misma, y un empleador lo contrata
    [Test]
    public void Escenario()
    {
        Administrador admin = new Administrador("855486554", "Esteban", "Mr.Quito@gmail.com"); // Creamos un nuevo administrador
        CategoriasManager.Instance.CrearCategoria("Pintura");

        Trabajador T1 = new Trabajador("485855224","Armando","Mr.Puertas@gmail.com","4478546-8",35,"24885513");
        OfertasManager.Instance.CrearOferta(Pintura,T1,"Pinto lo que sea cuando sea. Cobro mi tarifa mas gastos de pintura y locomoción");//Como llamar a la categoria

        Empleador E1 = new Empleador("88458468", "Mario","Mr.Brothers@gmail.com","4415348-2",45,"22165578");
        ContratosManager.Instance.CrearContrato(Oferta,E1);//Como llamo a la oferta?
    }
}