// 2. Factory
// El patrón Factory proporciona una forma de crear objetos sin especificar la clase exacta que se va a crear. Es útil para evitar acoplamientos fuertes y cuando se quiere delegar la creación de objetos a una clase especializada.

public interface IPruduct
{
    string ObtenerDescripcion();
}

public class ProductA : IProduct
{
    public string ObtenerDescripcion() => "Este es el producto A";
}

public class ProductB : IProduct
{
    public string ObtenerDescripcion() => "Este es el producto B";
}

public class ProductFactory
{
    public IPruduct CrearProducto(string tipo)
    {
        if (tipo == "A") return new ProductA();
        if (tipo == "B") return new ProductB();
        throw new ArgumentException("Tipo desconocido");
    }
}