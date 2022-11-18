using System.Collections.Generic;
namespace ClassLibrary;
public class OfertasManager


{
    public List<Oferta> Lista= new List<Oferta>();
    public OfertasManager()////Esto se va a crear en el programa principal y cada una de las ofertas deben ser guardadas aca
    {
        this.Lista= new List<Oferta>();
    }

    public void CrearOferta(Categoria categoria,  Usuario ofertante, string descripcion)
    {
        Oferta oferta = new Oferta(categoria, ofertante, descripcion);
    }
    public void RemoveOferta(Oferta Oferta)
    {
        if (this.Lista.Contains(Oferta))
        {
            this.Lista.Remove(Oferta);
        }
    }

    public void GetOfertas()///////////////////////////////////////////
    {
    }
    public void OfertasPorCategoria (string categoria)
    {
    }
}