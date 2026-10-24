using System;
using System.Collections.Generic;
using System.Text;
using FreightCooperative.Domain.Common;
using FreightCooperative.Domain.Enums;
namespace FreightCooperative.Domain.Entities
{
    public class Warehouse : BaseEntity
    {
        public string WarehouseName { get; set; } = string.Empty;
        public string WarehousePhone { get; set; } = string.Empty;
        public string WarehouseAddress { get; set; } = string.Empty;

        public int CityId { get; set; }
        public City City { get; set; } = null!;

        public ICollection<Customer> Customers { get; set; } =
            new List<Customer>();
        public ICollection<Shipment> SentShipments { get; set; } =
            new List<Shipment>();//SenderWarehouseId
        public ICollection<Shipment> ReceivedShipments { get; set; } =
            new List <Shipment>();//ReceiverWarehouseId



    }
}
