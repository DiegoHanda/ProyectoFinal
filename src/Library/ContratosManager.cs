using System;
namespace ClassLibrary;
public sealed class ContratosManager
{
    private readonly static ContratosManager _instance = new ContratosManager(); // Singleton pattern
    private ContratosManager() {}                                               //Al delegar la creacion de algunos objetos(como los contratos) estamos respetando el patron creator
    public static ContratosManager Instance { get { return _instance; } }

    public Contrato contratoCreado {get; set;}
    public Empleador empleadorCreado {get; set;}
    public void CrearContrato(Oferta oferta,  Empleador empleador) // Este metodo se usa para contruir contratos
    {
        Contrato contrato = new Contrato(oferta, empleador); // Instancia un nuevo contrato
        contratoCreado = contrato; // Asigna al public getter
        empleadorCreado = empleador; // Asigna al public getter
    }
}
