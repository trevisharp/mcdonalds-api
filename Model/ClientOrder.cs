﻿using System;
using System.Collections.Generic;

namespace McDonaldsAPI.Model;

public partial class ClientOrder
{
    public int Id { get; set; }

    public string OrderCode { get; set; }

    public int StoreId { get; set; }

    public DateTime? FinishMoment { get; set; }

    public DateTime? DeliveryMoment { get; set; }

    public virtual ICollection<ClientOrderItem> ClientOrderItems { get; set; } = new List<ClientOrderItem>();

    public virtual Store Store { get; set; }
}
