using System;
using System.Collections.Generic;
using System.Text;
using QuickBuy.Domain.Enum;

namespace QuickBuy.Domain.Valuables
{
    public class PaymentMethod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsBankSlip
        {
            get { return Id == (int)PaymentMethodEnum.BankSlip; }
        }

        public bool IsCreditCard
        {
            get { return Id == (int)PaymentMethodEnum.CreditCard; }
        }

        public bool IsDebitCard
        {
            get { return Id == (int)PaymentMethodEnum.DebitCard; }
        }

        public bool IsDeposit
        {
            get { return Id == (int)PaymentMethodEnum.Deposit; }
        }

    }
}
