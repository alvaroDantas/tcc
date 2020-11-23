using System;
using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class Request
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public ICollection<RequestItem> RequestItem { get; set; }
    }
}
