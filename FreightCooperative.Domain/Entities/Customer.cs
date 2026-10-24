using System;
using System.Collections.Generic;
using System.Text;
using FreightCooperative.Domain.Common;

namespace FreightCooperative.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;

        //computed i C# not stored in the database (ignore it in fluent API)
        public string FullName => $"{FirstName} {LastName}".Trim();

        //Warehouse where this Customer is registered
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; } = null!;

        public ICollection<Shipment> SentShipments { get; set; } =
            new List<Shipment>(); //SenderCustomerId
        public ICollection<Shipment> ReceivedShipments { get; set; } =
            new List<Shipment>(); //ReceivedCustomerId
    }
}
