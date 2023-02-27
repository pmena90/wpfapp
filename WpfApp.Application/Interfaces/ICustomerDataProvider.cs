using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp.Domain.Entities;

namespace WpfApp.Application.Interfaces
{
    public interface ICustomerDataProvider
    {
        Task<IEnumerable<Customer>?> GetAllAsync();
    }
}