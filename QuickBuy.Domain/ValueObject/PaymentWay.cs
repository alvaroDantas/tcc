using QuickBuy.Domain.Enums;

namespace QuickBuy.Domain.ValueObject
{
    public class PaymentWay
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsBankSlip 
        {
            get
            {
                return Id == (int)PaymentWayType.BankSlip;
            } 
        }
        public bool IsCreditCard
        {
            get
            {
                return Id == (int)PaymentWayType.CreditCard;
            }
        }
        public bool IsDeposit
        {
            get
            {
                return Id == (int)PaymentWayType.Deposit;
            }
        }
        public bool IsNotDefined
        {
            get
            {
                return Id == (int)PaymentWayType.NotDefined;
            }
        }

    }
}
