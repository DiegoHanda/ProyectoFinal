/*-Cómo administrador, quiero poder indicar categorías sobre las cuales se realizarán las ofertas de servicios para que de esa forma, los trabajadoras puedan clasificarlos.

-Como administrador, quiero poder dar de baja ofertas de servicios, avisando al oferente para que de esa forma, pueda evitar ofertas inadecuadas.*/

using System;
using System.Collections.Generic;
namespace ClassLibrary;
//Creemos que el administrador deberia conocer la lista de categorias. Como se hace?
//Creemos que el administrador deberia conocer la lista de ofertas. Como se hace?
public class Administrador
{
    public string NumbreUsuario {get; set;}
    public string Contraseña {get;set;}

    public void AddCategoria(string categoria)//Estos metodos deberian ir en el handler mas adelante
    {
        if (!categorias.Contains(categoria))
        Categorias.Add(categoria);
    }

    public void RemoveCategoria(string categoria)//Estos metodos deberian ir en el handler mas adelante
    {
        if (categorias.Contains(categoria))
        {
            categorias.Remove(categoria);
        }
    }

    public void RemoveOferta(string oferta)//Estos metodos deberian ir en el handler mas adelante
    {
        if (categorias.Contains(oferta))
        {
            categorias.Remove(oferta);
        }
    }

    public string Registrarse()//como se implementa esto?
    {
        return ("Estas registrado");
    }
}
