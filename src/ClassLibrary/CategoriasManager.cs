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
        }//Podriamos poner algo que avise si la categoria ya esta en la lista
    }

    public void RemoveCategoria(Categoria categoria)
    {
        if (this.Lista.Contains(categoria))
        {
            this.Lista.Remove(categoria);
        }//Tambien podemos poner aca si la categoria ya fue eliminada o no existe
    }
}








                //Cada usuario al tomar una accion deberia ser cuestionado si puede o no. los trabajadores no deben tener privilegios de administrador





public void AddCategoria(string categoria)//Estos metodos deberian ir en el handler mas adelante
    {
        if (!categorias.Contains(categoria))
        {
            Categorias.Add(categoria);
        }
    }

    public void RemoveCategoria(string categoria)//Estos metodos deberian ir en el handler mas adelante
    {
        if (categorias.Contains(categoria))
        {
            categorias.Remove(categoria);
        }
    }