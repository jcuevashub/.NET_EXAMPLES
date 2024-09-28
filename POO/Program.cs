//Clases y Objetos
//Una clase es una plantilla para cera objetos. Los objetos son instancias de una clase.

public class Persona
{
    public string? Nombre { get; set; }
    public int? Edad { get; set; }

    public void Presentarse()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Persona persona = new Persona();
        persona.Nombre = "Carlos";
        persona.Edad = 30;

        persona.Presentarse();
    }
}