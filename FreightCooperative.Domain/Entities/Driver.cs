using System;
using System.Collections.Generic;
using System.Text;
using FreightCooperative.Domain.Common;

namespace FreightCooperative.Domain.Entities
{
    public class Driver : BaseEntity
    {   public string FirstName { get; set;  } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Phone {  get; set; } = string.Empty;
        public string? VehicleInfo {  get; set; } //optional
        public string FullName => $"{FirstName} {LastName}".Trim();
        public ICollection<Shipment> Shipments { get; set; } =
            new List<Shipment>();

    }
}
