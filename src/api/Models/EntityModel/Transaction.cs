using System;

namespace api.Models
{
    public class Transaction
    {
        public long TransactionId { get; set; }
        public DateTime TransactionAt { get; set; }
        public DateTime? TransactionPaymentAt { get; set; }
        public string TransactionAcquirerConfirmation { get; set; }
        public decimal TransactionValue { get; set; }
        public decimal TransactionTax { get; set; }
        public decimal TransactionPayment { get; set; }
        public int TransactionInstallments { get; set; }
        public string TransactionLastCardDigits { get; set; }
    }
}
