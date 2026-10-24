using System;
using System.Collections.Generic;
using System.Text;
using FreightCooperative.Domain.Common;

namespace FreightCooperative.Domain.Entities
{
    public class City: BaseEntity
    {
        public string CityName { get; set; } = string.Empty;
        public ICollection<Warehouse> Warehouses { get; set; } =
            new List<Warehouse>();
        public ICollection<Shipment> SentShipments { get; set; } = 
            new List<Shipment>(); //SenderCityId
        public ICollection<Shipment> ReceivedShipments { get; set; } = 
            new List<Shipment>();//ReceiverCityId
    }
}
