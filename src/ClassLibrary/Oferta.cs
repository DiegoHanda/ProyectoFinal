using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Oferta   
{
    public Oferta(string categoria, ArrayList<int> coordenadas)
    {
        this.categoria = categoria;
        this.coordenadas = coordenadas;
    }
}