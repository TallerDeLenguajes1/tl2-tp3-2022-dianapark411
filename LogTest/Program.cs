// See https://aka.ms/new-console-template for more information
using NLog;

string ruta = @"C:\DIANA\Facultad\3er ANIO\2do Cuatrimestre\Taller de lenguajes II\TP3\tl2-tp3-2022-dianapark411\LogTest";

//Helper.crearCSV(ruta, "cadetes", "ID; NOMBRE; DIRECCION; TELEFONO");

var Logger = LogManager.GetCurrentClassLogger();
List<Cadete> cadetes = new List<Cadete>();
Helper.leerCadetes(ruta, "cadetes", cadetes);

Cadeteria cadeteria = new Cadeteria("Cadeteria Tucuman", 4631010, cadetes);



int opcion = 0;
do{
    Console.WriteLine("QUE OPERACION DESEA REALIZAR?");
    Console.WriteLine("1- cargar pedidos");
    Console.WriteLine("2- asignarlos a cadetes");
    Console.WriteLine("3- cambiarlos de estado");
    Console.WriteLine("4- cambiarlos de cadete");

    opcion = Convert.ToInt32(Console.ReadLine());
}while(opcion != 1 || opcion != 2 || opcion != 3 || opcion != 4);

if(opcion == 1){
    Console.WriteLine("Ingrese la cantidad de pedidos: ");
    List<Pedido> pedidos = new List<Pedido>();
    int cant_pedidos = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < cant_pedidos; i++)
    {
        Console.WriteLine("Número de pedido: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Observacion del pedido: ");
        string observacion = Console.ReadLine();
        Console.WriteLine("ID del cliente: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nombre del cliente: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Dirección del cliente: ");
        string direc = Console.ReadLine();
        Console.WriteLine("Teléfono del cliente: ");
        int tel = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Datos de la dirección del cliente: ");
        string datos = Console.ReadLine();

        pedidos.Add(new Pedido(num, observacion, "en preparacion", id, nombre, direc, tel, datos));
        Console.WriteLine($"Pedido generado con número {num}");
    }
}

cadeteria.mostrarCadeteria();