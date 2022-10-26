using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Oferta   
{
    public Oferta(Categoria categoria,  Usuario ofertante, ArrayList<int> coordenadas, string descripcion)
    {
        this.Categoria = categoria;
        this.ofertante = ofertante;
        this.Coordenadas = coordenadas;
        this.Descripcion = descripcion;
    }
}