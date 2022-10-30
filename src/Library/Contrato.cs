using System;
namespace ClassLibrary;

public class Contrato   
{
    public Oferta Oferta {get; set;}
    public Empleador Empleador {get; set;}
    public Contrato(Oferta oferta, Empleador Empleador) // Constructor del contrato
    {
        this.Oferta = oferta;
        this.Empleador = Empleador;
    }
}