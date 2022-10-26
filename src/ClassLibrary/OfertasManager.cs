namespace ClassLibrary;
public class OfertasManager

{
    public OfertasManager(var lista)////Esto se va a crear en el programa principal y cada una de las ofertas deben ser guardadas aca
    {
        this.Lista=lista;
    }

    public void CrearOferta(Categoria categoria,  Usuario ofertante, ArrayList<int> coordenadas, string descripcion)
    {
        Oferta oferta = new Oferta(categoria, ofertante, coordenadas,descripcion);
    }
    public void RemoveOferta(Oferta Oferta)
    {
        if (this.Lista.Contains(Oferta))
        {
            this.Lista.Remove(Oferta);
        }
    }
    public void Ofertas()
    {
        /////???????????
    }
}