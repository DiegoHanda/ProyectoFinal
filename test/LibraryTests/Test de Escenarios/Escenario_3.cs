using NUnit.Framework;
using ClassLibrary;
namespace Library.Tests;

[TestFixture]
public class Escenario_3
{//Despues de completar su trabajo, el emleador y el trabajador se puntuan y se cierra el contrato
    [Test]
    public void Escenario()
    {
        Administrador admin = new Administrador("1234567-5", "Esteban", "Mr.Quito@gmail.com"); // Como nota aparte, odriamos poner algo en el contrato que diga si esta activo o no
        CategoriasManager.Instance.CrearCategoria("Pintura");

        Trabajador T1 = new Trabajador("485855224","Armando","Mr.Puertas@gmail.com","4478546-8",35,"24885513");
        OfertasManager.Instance.CrearOferta(Pintura,T1,"Pinto lo que sea cuando sea. Cobro mi tarifa mas gastos de pintura y locomoción");//Como llamar a la categoria

        Empleador E1 = new Empleador("88458468", "Mario","Mr.Brothers@gmail.com","4415348-2",45,"22165578");
        ContratosManager.Instance.CrearContrato(Oferta,E1);

        
    }
}