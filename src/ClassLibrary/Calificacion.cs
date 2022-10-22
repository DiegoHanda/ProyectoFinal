using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Calificacion   
{
    public int Value {get; set;}
    public string Calificador {get; set;}
    public string Calificado {get; set;}
    public Calificacion(int value, string calificador, string calificado)
    {
        Value = value;
        Calificador = calificador;
        Calificado = calificado;
    }
}