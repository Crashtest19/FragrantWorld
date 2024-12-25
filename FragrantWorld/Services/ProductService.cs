using FragrantWorld.Database;
using FragrantWorld.Interface;
using FragrantWorld.modeles;


namespace FragrantWorld.Services
{
    public class ProductService : IProductService
    {
        private readonly AppDbContext _context;

        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public List<Product> GetProductList()
        {
            return _context.Products.ToList();
        }
    }
}
