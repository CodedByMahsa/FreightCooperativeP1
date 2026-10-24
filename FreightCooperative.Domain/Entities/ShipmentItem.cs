using System;
using System.Collections.Generic;
using System.Text;

namespace FreightCooperative.Domain.Entities
{
    //Bridge Table (Shipment n --- m Item)
    //Dosent inherit Base Entity because its key is composite:
    //(ShipmentId , ItemId)
    //Configure the Composite key in the Data layer:
    //build.Hashkey(x => new {x.ShipmentId, x.ItemId});
    public class ShipmentItem 
    {
        public int ShipmentId {  get; set; }
        public Shipment Shipment { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; } = null!;

        public decimal Quantity { get; set; }
        public decimal ItemValue { get; set; }


    }
}
