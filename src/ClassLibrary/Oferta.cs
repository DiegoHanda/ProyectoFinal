using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Oferta   
{
    public Oferta(string categoria, ArrayList<int> coordenadas, decimal precio)
    {
        this.categoria = categoria;
        this.coordenadas = coordenadas;
        this.precio= precio;
    }
    public bool verificarCategoria(){
        return;
    }
}