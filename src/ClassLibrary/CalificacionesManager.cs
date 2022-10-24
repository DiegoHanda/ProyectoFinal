namespace ClassLibrary;
public class CalificacionesManager
{
    public CalificacionesManager()
    {

    }
    public void CrearCalificacion(int value,  string calificador, string calificado)
    {
        Calificacion c1= new Calificacion(value, calificador, calificado);
        ListaCalificaciones.Add(c1);

    }
    public void ObtenerCalificacion()
    {

    }

}