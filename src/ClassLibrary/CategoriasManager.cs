using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class CategoriasManager
{
    List<Categorias> lista=new List<Categorias>();
    public CategoriasManager()
    {
        this.Lista =lista;
    }
public void AddCategoria(Categoria categoria)
    {
        if (!lista.Contains(categoria))
        {
            Categorias.Add(categoria);
        }
        else
        {
            Console.WriteLine("La categoria ya existe");
        }
    }

    public void RemoveCategoria(Categoria categoria)
    {
        if (this.Lista.Contains(categoria))
        {
            this.Lista.Remove(categoria);
        }
        else 
        {
            Console.WriteLine("La categoria no esta en la lista");
        }
    }
}
                //Cada usuario al tomar una accion deberia ser cuestionado si puede o no. los trabajadores no deben tener privilegios de administrador

