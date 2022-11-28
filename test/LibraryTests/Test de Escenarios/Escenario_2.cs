using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class Escenario_2
{//El administrador se da cuenta que una categoria se ha vuelto obsoleta, por lo que decide eliminarla de la lista, pero mantiene las ofertas ya realizadas por si queda algun interesado
    [Test]
    public void Escenario()
    {
        Administrador admin = new Administrador("1234567-5", "Esteban", "Mr.Quito@gmail.com"); // Creamos un nuevo administrador
        CategoriasManager.Instance.CrearCategoria("Cantante de Bar");

        Trabajador T1 = new Trabajador("485855224","Armando","Mr.Puertas@gmail.com","4478546-8",35,"24885513");
        OfertasManager.Instance.CrearOferta("Cantante de Bar",T1,"Pinto lo que sea cuando sea. Cobro mi tarifa mas gastos de pintura y locomoción");//Como llamar a la categoria

        CategoriasManager.Instance.RemoveCategoria("Cantante de Bar")

        //assert que no este en la lista
        //assert que la oferta siga en pie
    }
}