﻿namespace StockManagement.DataContracts;

public class CreateCustomerModel
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Street { get; set; }
    public required string PostalCode { get; set; }

    public required int AppartmentNumber { get; set; }
    public object Id { get; internal set; }
}
