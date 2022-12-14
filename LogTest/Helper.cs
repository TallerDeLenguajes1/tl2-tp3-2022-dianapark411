public static class Helper{
    
    public static void crearCSV(string ruta, string nombre, string encabezado){
    
        if(Directory.Exists(ruta)){
            FileStream fileStream;

            if(!File.Exists(ruta + @$"\{nombre}.csv")){
                Console.WriteLine("Creando archivo csv...");
                fileStream = File.Create(ruta + @$"\{nombre}.csv");
                fileStream.Close();
            }

            var archivo = new FileStream(ruta + @$"\{nombre}.csv", FileMode.Truncate);

            StreamWriter escribir = new StreamWriter(archivo);
            escribir.Write(encabezado);
            escribir.Close();
            archivo.Close();
            
        }
        else{
            Console.WriteLine("La ruta ingresada no existe");
        }
    }
    /*
    public static void escribir_contenido(string ruta, string nombre, Alumno a){
        if(File.Exists(ruta + @$"\{nombre}.csv")){
            StreamWriter file = new StreamWriter(ruta + @$"\{nombre}.csv", true);

            file.WriteLine($"{a.Id};{a.Nombre};{a.Apellido};{a.Dni}");

            file.Close();   
        }
    }
    */

    public static void leerCSV(string ruta, string nombre){
        if(File.Exists(ruta + @$"\{nombre}.csv")){
            StreamReader file = new StreamReader(ruta + @$"\{nombre}.csv");
            string line = "";
            //Lee linea por linea hasta que termina el archivo
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            file.Close();   
        }
    }

    public static void leerCadetes(string ruta, string nombre, List<Cadete> _cadetes)
    {
        if(File.Exists(ruta + @$"\{nombre}.csv")){
            
            StreamReader file = new StreamReader(ruta + @$"\{nombre}.csv");

            string line = "";
            //Lee linea por linea hasta que termina el archivo
            while ((line = file.ReadLine()) != null)
            {
                string[] Fila = line.Split(';');
                _cadetes.Add(new Cadete(Convert.ToInt32(Fila[0]), Fila[1], Fila[2], Convert.ToInt32(Fila[3])));
            }
        }
    }
    
    public static void limpiar_contenido(string ruta, string nombre){
        if (Path.GetFileName(ruta + @$"\{nombre}.csv").Split(';')[1] == "csv") File.Delete(ruta + @$"\{nombre}.csv");
    }
}