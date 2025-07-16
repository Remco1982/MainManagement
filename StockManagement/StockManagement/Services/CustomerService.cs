using StockManagement.DataContracts;
using StockManagement.Interfaces.Services;
using StockManagement.Models;

namespace StockManagement.Services;

public class CustomerService : ICustomerService
{
    private readonly CustomerRepository repository;

    public CustomerService()
    {
        repository = new CustomerRepository();
    }

    public Customer[] GetAll() => repository.GetAll();

    public Customer GetCustomerById(int id) => repository.GetById(id);

    public Customer Create(Customer customer)
    {
        var createdCustomer = repository.CreateCustomer(customer);
        return createdCustomer;
    }

    public void Delete(int id) => repository.DeleteById(id);

    public void Update(Customer customer)
    {
        var dbModel = repository.GetById(customer.Id);

        dbModel.FirstName = customer.FirstName;
        dbModel.LastName = customer.LastName;
        dbModel.AppartmentNumber = customer.AppartmentNumber;
        dbModel.PostalCode = customer.PostalCode;
        dbModel.Street = customer.Street;
        repository.UpdateCustomer(dbModel);
    }
}