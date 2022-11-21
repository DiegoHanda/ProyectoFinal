using System;
namespace ClassLibrary;
using System.Collections.Generic;
public sealed class ContratosManager
{
    private readonly static ContratosManager _instance = new ContratosManager(); // Singleton pattern
    private ContratosManager() {}
    public static ContratosManager Instance { get { return _instance; } }
    public List<Contrato> Contratos = new List<Contrato>();
    public Empleador empleadorCreado {get; set;}    
    public void CrearContrato(Oferta oferta,  Empleador empleador) //Este método crea una instancia de Categoria
    {
        Contrato contrato = new Contrato(oferta, empleador); // Instancia un nuevo contrato
        Contratos.Add(contrato);
    }

    public void RemoveContrato(Contrato contrato)
    {
        if (Contratos.Contains(contrato)) {
            Contratos.RemoveAll(x => x == contrato);
        }
    }
}
