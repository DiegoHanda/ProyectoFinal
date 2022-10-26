/*-Cómo administrador, quiero poder indicar categorías sobre las cuales se realizarán las ofertas de servicios para que de esa forma, los trabajadoras puedan clasificarlos.

-Como administrador, quiero poder dar de baja ofertas de servicios, avisando al oferente para que de esa forma, pueda evitar ofertas inadecuadas.*/

using System;
using System.Collections.Generic;
namespace ClassLibrary;
public class Administrador: Usuario
{
    public Administrador (string nombre, string email, int edad, string telefono, string contraseña, string cedula)
    :base(nombre, email, edad,telefono, contraseña,cedula)
    {

    }
}
