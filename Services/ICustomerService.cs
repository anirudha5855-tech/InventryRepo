using Inventy_Demo_MVC_Core.models;

namespace Inventy_Demo_MVC_Core.Services
{
    public interface ICustomerService
    {
        Task<TblCustomer> AddCustomer(TblCustomer customer);
        Task<TblCustomer> GetCustomer(int id);
        Task<List<TblCustomer>> GetCustomers();
    }
}
