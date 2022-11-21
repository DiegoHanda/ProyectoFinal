using System.Collections.Generic;
using System.Linq;
namespace ClassLibrary;
public class OfertasManager


{
    public List<Oferta> Ofertas = new List<Oferta>();
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