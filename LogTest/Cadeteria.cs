public class Cadeteria{
    private string nombre;
    private int telefono;
    private List<Cadete> listadoCadetes;

    public string Nombre { get => nombre; set => nombre = value; }
    public int Telefono { get => telefono; set => telefono = value; }
    internal List<Cadete> ListadoCadetes { get => listadoCadetes; set => listadoCadetes = value; }

    public Cadeteria(){}
    public Cadeteria(string _nombre, int _telefono){
        Nombre = _nombre;
        Telefono = _telefono;
    }
    public Cadeteria(string _nombre, int _telefono, List<Cadete> _cadetes){
        Nombre = _nombre;
        Telefono = _telefono;
        ListadoCadetes = _cadetes;
    }

    public void mostrarCadeteria(){
        Console.WriteLine("INFORMACION DE LA CADETERIA: ");
        Console.WriteLine("NOMBRE: ", Nombre);
        Console.WriteLine("TELEFONO: ", Telefono);
        foreach (var item in ListadoCadetes)
        {
            item.mostrarCadetes();
        }
    }
}