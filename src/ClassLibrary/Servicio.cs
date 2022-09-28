using System;
using System.Collections.Generic;

namespace ClassLibrary;
public class Servicio
{
    public string ID {get; set;}
    public string Categoria {get; set;}
    public int Orden {get;}
    public string Oferente  {get; set;}

    public Servicio(Trabajador trabajador,string categoria)
    {
        Oferente=trabajador;
        Categoria=categoria;
        Orden=setOrden(Categoria);
        ID="(Orden)-(IDTrabajador)";
    }
    public int setOrden(string tipo)
    {
        List<string> categorias = new List<string>() {"Peluquería","Jardinería","Albañilería","Limpieza"};
        int item = tipo;
 
        int index = list.IndexOf(item);
        if (index != -1) 
        {
            return index;
        }
        else 
        {
            Console.WriteLine ($"No existe la categoría: {0}", tipo);
            break;
        }
    }

}