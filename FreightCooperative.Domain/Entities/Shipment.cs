using System;
using System.Collections.Generic;
using System.Text;
using FreightCooperative.Domain.Common;
using FreightCooperative.Domain.Enums;

namespace FreightCooperative.Domain.Entities
{
    public class Shipment: BaseEntity
    {
        public ShipmentType ShipmentType { get; set; }
        public ShipmentStatus ShipmentStatus { get; set; }
        = ShipmentStatus.Created;
        public DateTime IssuedAt { get; set; } =
            DateTime.UtcNow;

        //-----------Sender-----------
        //Customer is nullable : the sender may be someone not
        //registered as a Customer, so name and phone are stored on the shipment itself
        public int? SenderCustomerId { get; set; }
        public Customer? SenderCustomer { get; set; }
        public string SenderFullName { get; set; } = string.Empty;
        public string SenderPhone { get; set; } = string.Empty;
        public int SenderCityId { get; set; }
        public City SenderCity { get; set; } = null!;
        public int SenderWarehouseId { get; set; }
        public Warehouse SenderWarehouse { get; set; } = null!;

        //-----------Receiver-----------
        public int? ReceiverCustomerId { get; set; }
        public Customer? ReceiverCustomer { get; set; }
        public string ReceiverFullName { get; set; } = string.Empty;
        public string ReceiverPhone { get; set; } = string.Empty;
        public int ReceiverCityId { get; set; }
        public City ReceiverCity { get; set; } = null!;
        public int ReceiverWarehouseId { get; set; }
        public Warehouse ReceiverWarehouse { get; set; } = null!;

        //-----------Driver (nullable: assigned later)-----------
        public int? DriverId { get; set; }
        public Driver? Driver { get; set; }

        //-----------Costs-----------
        public decimal PrepaidCost { get; set; }
        public decimal CodCost { get; set; }// cash on delivery
        public decimal shippingCost {  get; set; }
        public decimal PackingCost { get; set; }
        public decimal InsuranceCost { get; set; }
        public decimal OtherCost { get; set; }
        public decimal TotalCost { get; set; }
        public string? DestinationDescription { get; set; }
        public ICollection<ShipmentItem> ShipmentItems { get; set; } =
            new List<ShipmentItem>();
        //call this before saving , adjust the formula if your cooperative
        //counts PrepaidCost/CodCost defferently
        public void CalculateTotalCost()
        {
            TotalCost = shippingCost + PackingCost + InsuranceCost + OtherCost;
        }
    }
}
