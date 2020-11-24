using QuickBuy.Domain.ValueObject;
using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Request
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
        public ICollection<RequestItem> RequestItem { get; set; }
    }
}
