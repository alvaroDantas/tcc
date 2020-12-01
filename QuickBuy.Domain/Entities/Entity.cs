using System.Collections.Generic;
using System.Linq;

namespace QuickBuy.Domain.Entities
{
    public abstract class Entity
    {
        public List<string> _validationsMessages { get; set; }
        private List<string> validationMessage
        {
            get
            {
                return _validationsMessages ?? (_validationsMessages = new List<string>());
            }
        }

        public abstract void Validate();
        protected bool IsValid
        {
            get { return !validationMessage.Any(); }
        }
        protected void ClearValidationMessages()
        {
            validationMessage.Clear();
        }
        protected void AddCritical(string message)
        {
            validationMessage.Add(message);
        }
    }
}
