//Hello World
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hola Mundo desde .NET!");
//     }
// }

//Variables y Tipos de Datos
// int edad = 25;
// string nombre = "Juan";
// bool esEstudiante = true;
// Console.WriteLine($"Hola, mi nombre es {nombre}, tengo {edad} años y ¿soy estudiante? {esEstudiante}");


//Operadores y Expresiones
//C# admite operadores aritméticos, de comparación y lógicos. Aquí un ejemplo de cómo utilizarlos:
/*int a = 10;
int b = 11;

Console.WriteLine($"Suma: {a + b}");
Console.WriteLine($"Resta: {a - b}");
Console.WriteLine($"Multiplicación: {a * b}");
Console.WriteLine($"División: {a / b}");
Console.WriteLine($"¿a es mayor que b? {a > b}"); */

//Estructuras de Control en C#
//Las estructuras de control en C# te permiten controlar el flujo de ejecución en tu programa.
// int edad = 18;

// if(edad >= 18) {
//     Console.WriteLine("Eres mayor de edad.");
// } else {
//     Console.WriteLine("Eres menor de edad.");
// }

//Switch-case
//El Swith es útil cuando tiens múltiples condiciones
// int opcion = 2;
// switch (opcion)
// {
//     case 1:
//         Console.WriteLine("Opción 1 seleccionada.");
//         break;
//     case 2:
//         Console.WriteLine("Opción 2 seleccionada.");
//         break;
//     default:
//         Console.WriteLine("Opción no válida.");
//         break;
// }

//Bucles: for, while y foreach
//Los bucles permiten ejecutar un bloque de código varias veces.

// for(int i = 0; i < 10;i++){
//     Console.WriteLine($"Iteración {i}");
// }

//Bucle: while
// int contador = 0;
// while (contador < 5) {
//     Console.WriteLine($"Contador: {contador}");
//     contador++;
// }

//Bucle: foreach
string[] frutas = ["Manzana", "Banana", "Naranja"];

foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}