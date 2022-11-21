using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Calificacion          //Algunas de estas clases fueron separadas desde conceptos mas abstractos. Creando clases que tengan resposabilidades especificas
{
    public int Value {get; set;}   // para cumplir con el SRP
    public Cliente Calificador {get; set;}
    public Cliente Calificado {get; set;}
    public Calificacion(int value, Cliente calificador, Cliente calificado)
    {
        if (value>=1 && value<=5)
        {
            this.Value = value;
            this.Calificador = calificador;
            this.Calificado = calificado;
        }
        else
        {
            throw new Exception ($"{value} no es un puntaje válido");
        }


    }
}