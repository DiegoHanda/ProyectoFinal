using System;
namespace ClassLibrary;
public class ContratosManager
{
    public ContratosManager() {}

    public void CrearContrato(Oferta oferta,  Empleador empleador) // Este metodo se usa para contruir contratos
    {
        Contrato contrato = new Contrato(oferta, empleador); // Instancia un nuevo contrato
    }
}
