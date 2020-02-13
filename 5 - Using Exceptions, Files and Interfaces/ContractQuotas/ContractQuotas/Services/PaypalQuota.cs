using ContractQuotas.Interfaces;
namespace ContractQuotas.Services
{
    class PaypalQuota : IPaymentService
    {
        public double SimpleTax { get; set; }
        public double PaymentFee { get; set; }

        public PaypalQuota()
        {
            SimpleTax = 0.1;
            PaymentFee = 0.2;
        }

        public double QuotaCalc(double amount, int nInstallment)
        {
            double quota = amount;
            quota = amount * SimpleTax * nInstallment;
            quota = quota + quota * PaymentFee;
            return quota;
        }
    }
}
