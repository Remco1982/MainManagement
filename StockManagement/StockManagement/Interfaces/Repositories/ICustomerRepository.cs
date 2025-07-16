using StockManagement.Models;

namespace StockManagement.Interfaces.Repositories;

public interface ICustomerRepository
{
    Customer[] GetAll();
    Customer GetById(int id);
    Customer CreateProduct(Customer customer);
    void UpdateProduct(Customer customer);
    void DeleteById(int id);
}