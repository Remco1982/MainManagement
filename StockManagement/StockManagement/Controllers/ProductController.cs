using Microsoft.AspNetCore.Mvc;
using StockManagement.DataContracts;
using StockManagement.MockData;
using StockManagement.Models;
using StockManagement.Services;

namespace StockManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    [HttpGet]
    public ActionResult<ProductViewModel[]> GetAll()
    {
        var service = new ProductService();
        var products = service.GetAll();
        var viewModel = Mapper(products);

        return viewModel;
    }

    [HttpGet("{id}")]
    public ActionResult<ProductViewModel> GetProduct(int id)
    {
        var product = MockDataList.ProductList.Products.SingleOrDefault(x => x.Id == id);

        if (id == 3) // 3 = verboden toegang //
        {
            return Unauthorized();
        }

        if (product != null)
        {
            return Ok(product);
        }

        return NotFound();
    }

    [HttpPost]
    public ActionResult<ProductViewModel> Post([FromBody] CreateProductModel model)
    {
        var service = new ProductService();

        var domainModel = Mapper(model);
        var createdModel = service.Create(domainModel);
        var viewModel = Mapper(createdModel);

        return Ok(viewModel);
    }

    private ProductViewModel[] Mapper(Product[] model)
    {
        List<ProductViewModel> products = new();

        foreach (var product in model)
        {
    var mappedObject = Mapper(product);
    products.Add(mappedObject);
        }

        return products.ToArray();
    }

    private ProductViewModel Mapper(Product model)
    {
        return new ProductViewModel()
        {
            Id = model.Id,
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            Stock = model.Stock,
            DiscountPercentage = model.DiscountPercentage
        };
    }

    private Product Mapper(CreateProductModel model)
    {
        return new Product()
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            Stock = model.Stock,
            DiscountPercentage = model.DiscountPercentage
        };
    }
}