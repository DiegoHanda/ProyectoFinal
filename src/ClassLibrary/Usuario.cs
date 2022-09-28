public class Usuario
{
    public string Nombre {get; set;}
    public string Email {get; set;}
    public int Edad {get; set;}
    public string Telefono {get; set;}
    public string Contraseña;
    public string Cedula{get;}
    public List Calificaciones {get; set;}
    public Usuario(string nombre, string email,int edad,string telefono,string contraseña,string cedula)
    {
        Nombre = nombre;
        Email = email;
        Edad = edad;
        Telefono = telefono;
        Contraseña = contraseña;    
        Cedula = cedula;
        List <int> Calificaciones = new List();
    }
    public void calificar ()
    {
        
    }

}