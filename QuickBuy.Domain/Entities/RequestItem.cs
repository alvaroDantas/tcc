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
            if(ProductId == 0)
            {
                AddCritical("Does not was recognized the product reference");
            }
            if(Quantity == 0)
            {
                AddCritical("Quantity does not was informed");
            }
        }
    }
}
