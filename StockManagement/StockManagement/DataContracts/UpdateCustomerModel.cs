﻿namespace StockManagement.DataContracts
{
    public class UpdateCustomerModel : CreateCustomerModel 
    {
        public required int Id { get; set; }
    }
}
