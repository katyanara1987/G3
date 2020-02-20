using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using HomeTask8.Enums;

namespace HomeTask8.Model
{
    public class Shipment
    {
        [JsonPropertyName("shipmentid")]
        public string ShipmentId { get; set; }
        [JsonPropertyName("deliveryaddress")]
        public string Address { get; set; }
        [JsonPropertyName("orders")]
        public List<Order> Orders { get; set; }
    }
}
