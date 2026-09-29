using Inventy_Demo_MVC_Core.models;
using Microsoft.EntityFrameworkCore;

namespace Inventy_Demo_MVC_Core.Services
{
    public class CustomerService : ICustomerService
    {
        CiitPosAppContext db;
        public CustomerService(CiitPosAppContext db)
        {
            this.db = db;
        }

        public async Task<TblCustomer> AddCustomer(TblCustomer customer)
        {
            await db.TblCustomers.AddAsync(customer);
            await db.SaveChangesAsync();
            return customer;
        }

        public async Task<TblCustomer> GetCustomer(int id)
        {
            return await db.TblCustomers.FindAsync(id);
        }

        public async Task<List<TblCustomer>> GetCustomers()
        {
            return  await db.TblCustomers.ToListAsync();
        }
    }
}
