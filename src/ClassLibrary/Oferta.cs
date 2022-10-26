using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Oferta   
{
    public Oferta(Categoria categoria,  Usuario ofertante, string descripcion)
    {
        this.Categoria = categoria;
        this.ofertante = ofertante;
        this.Descripcion = descripcion;
    }
}