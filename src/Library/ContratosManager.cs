using System;
namespace ClassLibrary;
public class ContratosManager
{
    public ContratosManager() {}
    public Contrato contratoCreado {get; set;}
    public Empleador empleadorCreado {get; set;}
    public void CrearContrato(Oferta oferta,  Empleador empleador) // Este metodo se usa para contruir contratos
    {
        Contrato contrato = new Contrato(oferta, empleador); // Instancia un nuevo contrato
        contratoCreado = contrato; // Asigna al public getter
        empleadorCreado = empleador; // Asigna al public getter
    }
}
