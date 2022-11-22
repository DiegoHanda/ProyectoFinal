using System.Collections.Generic;
using System.Linq;
namespace ClassLibrary;
public sealed class OfertasManager
{
    private readonly static OfertasManager _instance = new OfertasManager(); // Singleton pattern
    private OfertasManager() {}
    public static OfertasManager Instance { get { return _instance; } }

    public List<Oferta> Ofertas = new List<Oferta>();
                                                                                                    //Este manager(igual que los otros) contiene toda la informacion sobre su respectiva area
                                                                                                    // por esto, tiene las responsabilidades de crear dichos objetos y de eliminarlos de una
                                                                                                    //lista. Por esto consideramos que se cumple el patron de Experto
    public void CrearOferta(Categoria categoria,  Trabajador ofertante, string descripcion)

    {
        Oferta oferta = new Oferta(categoria, ofertante, descripcion);
        Ofertas.Add(oferta);
    }
    public void RemoveOferta(Oferta Oferta)
    {
        if (Ofertas.Contains(Oferta)) {
            Ofertas.RemoveAll(x => x == Oferta);
        }
    }
    public List<Oferta> PorCategoria(string categoria) // Devolvemos ofertas por categoria
    {
        List<Oferta> PorCategoria = new List<Oferta>();

        foreach(var oferta in Ofertas) {
         if (oferta.Categoria.Nombre == categoria) { // Cada oferta cuya categoria coincida con el string va ser agregada a la lista
            PorCategoria.Add(oferta);
         }
        }

        return PorCategoria;
    }
    
    public List<Oferta> PorReputacion()
    {
        List<Oferta> PorReputacion = new List<Oferta>();

        PorReputacion.AddRange(Ofertas.OrderBy (p => p.Ofertante.Promedio));

        return PorReputacion;
    }
}