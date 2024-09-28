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
class Program
{
    static void Main(string[] args)
    {
        string ruta = "archivo.txt";

        if(File.Exists(ruta))
        {
            string contenido = File.ReadAllText(ruta);
            Console.WriteLine($"Contenido del archivo: {contenido}");
        }
         else
         {
            Console.WriteLine("El archivo no existe.");
         }
    }
}