public class Cliente: Persona{
    private string datosReferenciaDireccion;

    public string DatosReferenciaDireccion { get => datosReferenciaDireccion; set => datosReferenciaDireccion = value; }

    public Cliente(){}

    public Cliente(int _id, string _nombre, string _direccion, int _telefono, string _datosReferenciaDireccion):base(_id, _nombre, _direccion, _telefono){
        DatosReferenciaDireccion = _datosReferenciaDireccion;
    }

    public void mostrarCliente(){
        Console.WriteLine("INFORMACION DEL CLIENTE: ");
        this.mostrarPersona();
        Console.WriteLine($"Datos Referencia Direccion: {DatosReferenciaDireccion }");
    }
}
