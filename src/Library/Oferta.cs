using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Oferta   
{
    public Categoria Categoria {get; set;}
    public Trabajador Ofertante {get; set;}
    public string Descripcion {get; set;}

    public Oferta(Categoria categoria,  Trabajador ofertante, string descripcion)
    {
        this.Categoria = categoria;
        this.Ofertante = ofertante;
        this.Descripcion = descripcion;
    }
}