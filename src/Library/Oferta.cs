using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Oferta   
{
    public Categoria Categoria;/////esto no se si esta bien
    public Oferta(Categoria categoria,  Usuario ofertante, string descripcion)
    {
        this.Categoria = categoria;
        this.Ofertante = ofertante;
        this.Coordenadas = coordenadas;
        this.Descripcion = descripcion;
    }
}