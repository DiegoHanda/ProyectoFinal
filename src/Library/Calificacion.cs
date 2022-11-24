using System;
namespace ClassLibrary;
using System.Collections.Generic;

public class Calificacion   //Algunas de estas clases (Calificacion,Contrato, Ofertas)fueron separadas desde conceptos mas abstractos. Creando clases que tengan resposabilidades especificas
{                           // para cumplir con el SRP
    public int Value {get; set;}    
                                    
    public Cliente Calificador {get; set;}
    public Cliente Calificado {get; set;}
    public Calificacion(int value, Cliente calificador, Cliente calificado)  //Constructor de Calificacion
    {
        Check.Precondition(value>=1 && value<=5);        //Chequeamos precondiciones segun diseño por contrato
        this.Value = value;
        this.Calificador = calificador;
        this.Calificado = calificado;
    }
}