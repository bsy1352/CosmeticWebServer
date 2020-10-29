using System;
using System.Collections.Generic;

namespace CosmeticWebServer.Models.DBModels
{
    public partial class Orders
    {
        public int OrderNum { get; set; }
        public string OrderDetail { get; set; }
        public string OrderDate { get; set; }
        public string OrderState { get; set; }
    }
}
