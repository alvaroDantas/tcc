using System;

namespace QuickBuy.Domain.Entities
{
    public class RequestItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
