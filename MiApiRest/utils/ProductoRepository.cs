// 3. Repository
// El patrón Repository es usado para abstraer la lógica de acceso a los datos, permitiendo que el código de negocio no dependa de detalles específicos de la base de datos.

public interface IProductRepository
{
    Product ObtenerPorId(int id);
    void Agregar(Product product);
}

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext = _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public Product ObtenerPorId(int id) 
    {
        return _context.Products.Find(id);
    }

    public void Agregar(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }
}