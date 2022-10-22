using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Calificacion   
{
    public Calificacion(int value, string calificador, string calificado)
    {
        this.value = value;
        this.calificador = calificador;
        this.calificado = calificado;
    }
}