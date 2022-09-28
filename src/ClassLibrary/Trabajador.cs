using System;
using System.Collections.Generic;
namespace ClassLibrary;

public class Trabajador
{
    public string Nombre;
    public string Apellido;
    public intint ID;
    public ArrayList<int> Coordenadas;
    public string CedulaIdentidad;
    public string Usuario;
    public string Contraseña;
    public Trabajador(string nombre, string apellido, int ID, ArrayList<int> coordenadas, string cedulaIdentidad, string usuario, string contraseña)
    {
        this.Nombre=nombre;
        this.Apellido=apellido;
        this.ID=ID;
        this.Coordenadas=coordenadas;
        this.CedulaIdentidad=cedulaIdentidad;
    }
}