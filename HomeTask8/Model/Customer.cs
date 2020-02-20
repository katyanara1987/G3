using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace HomeTask8
{
    public class Customer
    {
        [JsonPropertyName("customerid")]
        public string CustomerGuid { get; set; }
        [JsonPropertyName("customername")]
        public string Name { get; set; }

        public override string ToString()
        {
            return $"CustomerID: {CustomerGuid} CustomerName: {Name}";
        }
    }
}
