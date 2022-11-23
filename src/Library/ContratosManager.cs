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
                                                                    //Al delegar la creacion de algunos objetos(como los contratos) estamos respetando el patron creator
    public void CrearContrato(Oferta oferta,  Empleador empleador) //Este método crea una instancia de Categoria
    {
        Contrato contrato = new Contrato(oferta, empleador); // Instancia un nuevo contrato
        Contratos.Add(contrato);
    }

    public void RemoveContrato(Contrato contrato)
    {
        Check.Precondition(Contratos.Contains(contrato));//Chequeamos precondiciones segun diseño por contrato
        Contratos.RemoveAll(x => x == contrato);
    }
}
