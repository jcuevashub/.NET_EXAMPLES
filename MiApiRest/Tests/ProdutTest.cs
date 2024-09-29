public class ProductTest
{
    [Fact]
    public void Producto_Deveria_TenerNombre()
    {
        var producto = new Product {Name = "Laptop"};
        Assert.Equal("Laptop", producto.Name);
    }
}