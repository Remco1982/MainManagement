using StockManagement.DataContracts;

namespace StockManagement.MockData;

public static class MockDataList
{
    public static ProductListViewModel ProductList = new ProductListViewModel()
    {
        Products = [
            new ProductViewModel()
            {
                Name = "Koffiemok",
                Description = "Een koffie houder",
                Id = 1,
                Price = 10.50m,
                Stock = 50
            },
            new ProductViewModel()
            {
                Name = "Theeglas",
                Description = "Een thee houder",
                Id = 2,
                Price = 6.50m,
                Stock = 20
            }
        ]
    };
}