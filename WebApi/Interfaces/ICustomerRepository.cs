using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Interfaces
{
    public interface ICustomerRepository
    {
        #nullable enable
        public Task<Customer?> GetCustomer(long id);
        #nullable disable

        public Task<long> CreateCustomer(Customer customer);
    }
}
