using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public class Request : Entity
    {
        public int Id { get; set; }
        public DateTime RequestDate { get; set; }
        public int UserId { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
        public string CEP { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int AddressNumber { get; set; }
        public int PaymentWayId { get; set; }
        public PaymentWay PaymentWay { get; set; }
        public ICollection<RequestItem> RequestItens { get; set; }

        public override void Validate()
        {
            ClearValidationMessages();

            if (!RequestItens.Any())
            {
                AddCritical("Error: Request does not can be with Request item");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AddCritical("Error: CEP must be fillied");
            }
        }
    }
}
