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
    }

}
