// Entrada y Salida de Datos
// // Puedes interactuar con el usuario utilizando Console.ReadLine() para obtener entradas y Console.WriteLine() para mostrar información.
// class Program
// {
//     static void Main(string[] args)
//     {
//         //Solicitar nombre
//         Console.Write("Introduce tu nombre: ");
//         string? nombre = Console.ReadLine();

//         //Solicitar edad
//         Console.Write("Introduce tu edad: ");
//         int? edad = int.Parse(Console.ReadLine());

//         //Mostrar resultado
//         Console.WriteLine($"Hola, {nombre}. Tienes {edad} años.");
//     }
// }

// En este ejemplo:

// Console.Write muestra un mensaje en la consola sin un salto de línea.
// Console.ReadLine() captura la entrada del usuario como una cadena.
// int.Parse convierte la cadena ingresada por el usuario en un número entero.

//----------------------------------------------------------------------------
// Parámetros de Línea de Comandos
// Puedes pasar argumentos a la aplicación mediante la línea de comandos. Estos se capturan en el array args del método Main.
// class Program
// {
//     static void Main(string[] args)
//     {
//         if (args.Length == 0)
//         {
//             Console.WriteLine("No se pasaron argumentos.");
//         }
//         else
//         {
//             Console.WriteLine("Argumentos recibidos: ");
//             foreach(string arg in args)
//             {
//                 Console.WriteLine(arg);
//             }
//         }
//     }
// }

// Lectura y Escritura de Archivos en Aplicaciones de Consola
// En muchas aplicaciones de consola, es común interactuar con archivos. Puedes leer y escribir archivos utilizando clases como File y StreamReader/StreamWriter.

//Lectura de Archivos
// class Program
// {
//     static void Main(string[] args)
//     {
//         string ruta = "archivo.txt";

//         if(File.Exists(ruta))
//         {
//             string contenido = File.ReadAllText(ruta);
//             Console.WriteLine($"Contenido del archivo: {contenido}");
//         }
//          else
//          {
//             Console.WriteLine("El archivo no existe.");
//          }
//     }
// }

//Escritura en Archivos

// class Program
// {
//     static void Main(string[] args)
//     {
//         string ruta = "archivo2.txt";
//         string contenido = "Este es el contenido del archivo.";

//         File.WriteAllText(ruta, contenido);
//         Console.WriteLine("El archivo ha sido creado y escrito.");
//     }
// }

// Manejo de Archivos con StreamReader y StreamWriter
// Para manejar archivos grandes o realizar operaciones avanzadas, StreamReader y StreamWriter permiten leer y escribir en un flujo de datos.

// Ejemplo: Leer un Archivo Línea por Línea
// class Program
// {
//     static void Main(string[] args)
//     {
//         using (StreamReader sr = new StreamReader("archivo.txt"))
//         {
//             string linea;
//             while ((linea = sr.ReadLine()) != null)
//             {
//                 Console.WriteLine(linea);
//             }
//         }
//     }
// }

// Manejo de Errores y Excepciones
// Cuando trabajas con entradas del usuario o archivos, es fundamental manejar errores para evitar que la aplicación falle.

// class Program
// {
//     static void Main(string[] args)
//     {
//         string ruta = "archivo4.txt";

//         try
//         {
//             string contenido = File.ReadAllText(ruta);
//             Console.WriteLine(contenido);
//         }
//         catch (FileNotFoundException)
//         {

//            Console.WriteLine("El archivo no fue encontrado.");
//         }
//         catch(Exception ex) 
//         {
//             Console.WriteLine($"Ocurrió un error: {ex.Message}");
//         }
//     }
// }

// En este ejemplo:

// FileNotFoundException captura el error específico de archivo no encontrado.
// Exception captura cualquier otro tipo de error general.

//1. Crear (Insertar un Nuevo Registro)

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            //1. Crear (Insertar un Nuevo Registro)
            // for (int i = 0; i > 10; i++)
            // {
            //     var producto = new Product
            //     {
            //         Name = $"Laptop: {i}",
            //         Price = 12000.99m
            //     };

            //     context.Products.Add(producto);
            //     context.SaveChanges();
            // }

            //2. Leer (Consultar Registros)
            // var productos = context.Products.ToList();

            // foreach(var product in productos) {
            //     Console.WriteLine($"{product.Id} - {product.Name} - ${product.Price}");
            // }

            //Filtrar Productos por Precio
            // var productosCaros = context.Products.Where(p => p.Price > 1000).ToList();

            // foreach (var product in productosCaros)
            // {
            //     Console.WriteLine($"{product.Name} cuesta ${product.Price}");
            // }

            //3. Actualizar (Modificar un Registro Existente)
            // var producto = context.Products.FirstOrDefault(p => p.Name == "Laptop");
            // producto.Price = 11000.99m;

            // context.SaveChanges();

            //4. Eliminar (Borrar un Registro)
            var producto = context.Products.FirstOrDefault(p => p.Name == "Laptop");

            context.Products.Remove(producto);
            context.SaveChanges();

        };

    }
}