using System;
using System.Collections.Generic;
using System.Text;
using FreightCooperative.Domain.Common;

namespace FreightCooperative.Domain.Entities
{
    public class Item : BaseEntity
    {
        public string ItemName { get; set; } = string.Empty;
        public string ItemUnit { get; set; } = string.Empty; // e.g. kg, box, piece
        public ICollection<ShipmentItem> ShipmentItems { get; set; } = 
            new List<ShipmentItem>();
    }
}
