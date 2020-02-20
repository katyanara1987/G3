using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HomeTask8.Model
{
    public class Order
    {
        [JsonPropertyName("orderid")]
        public int OrderId { get; set; }
        [JsonPropertyName("productquantity")]
        public int Quantity { get; set; }
        [JsonPropertyName("producttype")]
        public string ProductType { get; set; }
        [JsonPropertyName("customer")]
        public Customer Customer { get; set; }

        public override string ToString()
        {
            return $"OrderID: {OrderId} Quantity: {Quantity} ProductType: {ProductType}";
        }

    }
}
