using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using HomeTask8.Enums;


namespace HomeTask8.Model
{
    class ProcessInput
    {
        public void PrintShipment(string path)
        {

            string jsonString = File.ReadAllText(path);
            List<Shipment> shipment = JsonSerializer.Deserialize<List<Shipment>>(jsonString);

            Console.WriteLine("Do you want to print Shipments with details?");
            
            Answers answer = Answers.Yes;
            answer = EnumHelper.RequestForEnumValue<Answers>();

            foreach (var shipmentid in shipment)
            {
                Console.WriteLine($"{shipmentid.ShipmentId}  Delivery address: {shipmentid.Address}");
                if (answer == Answers.Yes)
                {
                    foreach (var orderid in shipmentid.Orders)
                    {
                        Console.WriteLine(orderid.ToString());
                        Console.WriteLine(orderid.Customer.ToString());
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
