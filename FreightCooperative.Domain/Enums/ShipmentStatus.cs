using System;
using System.Collections.Generic;
using System.Text;

namespace FreightCooperative.Domain.Enums
{
    public enum ShipmentStatus
    {
        Created = 1,
        InWarehouse = 2,
        Intransit = 3,
        Delivered = 4,
        Cancelled = 5
    };
}
