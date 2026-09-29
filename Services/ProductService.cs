using Inventy_Demo_MVC_Core.models;
using Microsoft.EntityFrameworkCore;

namespace Inventy_Demo_MVC_Core.Services
{
    public class ProductService:IProductService
    {
        CiitPosAppContext db;
        public ProductService(CiitPosAppContext db)
        {
            this.db = db;
        }

        public async Task<TblProduct> AddProduct(TblProduct product)
        {
            await db.TblProducts.AddAsync(product);
            await db.SaveChangesAsync();
            return product;
        }

        public async Task<TblProduct> GetProduct(int id)
        {
            return await db.TblProducts.FindAsync(id);
        }

        public async Task<List<TblProduct>> GetProducts()
        {
            return await db.TblProducts.ToListAsync();
        }
    }
}
