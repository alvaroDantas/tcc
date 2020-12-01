using System.Collections.Generic;

namespace QuickBuy.Domain.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Request> Requests { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
            {
                AddCritical("Email does not informed");
            }
            if (string.IsNullOrEmpty(Password))
            {
                AddCritical("Password does not informed");
            }
        }
    }
}
