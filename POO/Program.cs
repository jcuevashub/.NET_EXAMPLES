//Clases y Objetos
//Una clase es una plantilla para cera objetos. Los objetos son instancias de una clase.

// public class Persona
// {
//     public string? Nombre { get; set; }
//     public int? Edad { get; set; }

//     public void Presentarse()
//     {
//         Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {

//         Persona persona = new Persona();
//         persona.Nombre = "Carlos";
//         persona.Edad = 30;

//         persona.Presentarse();
//     }
// }

//Encapsulamiento, Herencia y Polimorfismo
// Encapsulamiento: Control del acceso a los miemros de una clase.
// Herencia: Permite que una clase herede de otra.
// Polimorfismo: Los métodos pueden comportarse de manera diferente según el contexto.

class Animal 
{
    public string Nombre { get; set; }

    public void Commer()
    {
        Console.WriteLine($"{Nombre} está comiendo.");
    }
}

class Perro : Animal
{
    public void Ladrar()
    {
        Console.WriteLine($"{Nombre} está ladrando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Perro perro = new Perro();
        perro.Nombre = "Max";
        perro.Commer();
        perro.Ladrar();
    }
}