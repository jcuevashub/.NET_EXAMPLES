public interface IUnitOfWork
{
    IProductRepository ProductRepository { get; }
    void Commit();
}

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;
    private IProductRepository _productRepository;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public IProductRepository ProductRepository
    {
        get 
        {
             return _productRepository ??= new ProductRepository(_context); 
        }
    }

    public void Commit()
    {
        _context.SaveChanges();
    }
}