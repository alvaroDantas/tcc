using System;

namespace QuickBuy.Domain.Entities
{
    public class RequestItem : Entity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
