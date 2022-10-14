public class Cadete: Persona{
    private List<Pedido> listadoPedidos;

    public List<Pedido> ListadoPedidos { get => listadoPedidos; set => listadoPedidos = value; }

    public Cadete(){}

    public Cadete(int _id, string _nombre, string _direccion, int _telefono, List<Pedido> _pedidos):base(_id, _nombre, _direccion, _telefono){
        foreach (var item in _pedidos)
        {
            ListadoPedidos.Add(new Pedido(item));
        }
    }

    public Cadete(int _id, string _nombre, string _direccion, int _telefono):base(_id, _nombre, _direccion, _telefono){}

    public void jornal_a_cobrar(){
        
    }

    public void mostrarCadetes(){
        Console.WriteLine("INFORMACION DEL CADETE: ");
        this.mostrarPersona();
        foreach (var item in ListadoPedidos)
        {
            item.mostrarPedido();
        }
    }
}