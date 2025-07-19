using StockManagement.DataContracts;
using StockManagement.Models;

namespace StockManagement.Interfaces.Services
{
    public interface ICustomerService
    {
        Customer[] GetAll();
        Customer GetCustomerById(int id);
        Customer Create(Customer customer);

        void Delete(int id);
        void Update(Customer customer);
        Task UpdateAsync(UpdateCustomerModel model);
        Task<bool> ExistsAsync(int id);
        Task DeleteAsync(int id);
        Task GetByIdAsync(int id);
        Task CreateAsync(CreateCustomerModel model);
        Task GetAllAsync();
    }

}
