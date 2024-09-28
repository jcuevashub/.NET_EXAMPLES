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
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("No se pasaron argumentos.");
        }
        else
        {
            Console.WriteLine("Argumentos recibidos: ");
            foreach(string arg in args)
            {
                Console.WriteLine(arg);
            }
        }
    }
}