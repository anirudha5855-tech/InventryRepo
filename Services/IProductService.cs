using Inventy_Demo_MVC_Core.models;

namespace Inventy_Demo_MVC_Core.Services
{
    public interface IProductService
    {
        Task<TblProduct> AddProduct(TblProduct product);
        Task<TblProduct> GetProduct(int id);
        Task<List<TblProduct>> GetProducts();
    }
}
