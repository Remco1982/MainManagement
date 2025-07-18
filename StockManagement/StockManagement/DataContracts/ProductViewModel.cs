﻿namespace StockManagement.DataContracts;

public class ProductViewModel
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public required decimal Price { get; set; }
    public required int Stock { get; set; }
    public int? DiscountPercentage { get; set; }
    public decimal CalculateDiscount =>
        DiscountPercentage.HasValue ? ((1 - DiscountPercentage.Value / 100m)) : Price;
}
