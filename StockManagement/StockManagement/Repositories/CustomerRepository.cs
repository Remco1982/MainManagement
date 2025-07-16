using Microsoft.EntityFrameworkCore;
using StockManagement.Models;

namespace StockManagement.DataContracts;

public class CustomerRepository
{
    private readonly AppDbContext _context;

    public CustomerRepository()
    {
        var connectionstring = "Host=localhost;Port=5432;database=stockdb;Username=postgres;Password=passpass";
        var optionBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionBuilder.UseNpgsql(connectionstring);
        _context = new AppDbContext(optionBuilder.Options);
    }

    public Customer GetById(int id) => _context.Customers.Single(x => x.Id == id);
    public Customer CreateCustomer(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
        return customer;
    }

    public Customer[] GetAll() => _context.Customers.ToArray();

    public void UpdateCustomer(Customer customer)
    {
        _context.Customers.Update(customer);
        _context.SaveChanges();
    }

    public void DeleteById(int id)
    {
        var customerToBeDeleted = GetById(id);
        _context.Customers.Remove(customerToBeDeleted);
        _context.SaveChanges();
    }
   public Customer CreateProduct(Customer customer)
    {
        _context.Customers.Add(customer);
        _context.SaveChanges();
        return customer;
    }

 }