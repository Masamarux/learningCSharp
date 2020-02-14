using ContractQuotas.Interfaces;
namespace ContractQuotas.Services
{
    class PaypalQuota : IPaymentService
    {
        public double SimpleTax { get; set; }
        public double PaymentFee { get; set; }

        public PaypalQuota()
        {
            SimpleTax = 0.01;
            PaymentFee = 0.02;
        }

        public double QuotaCalc(double amount, int nInstallment)
        {
            double quota = amount;
            quota = amount + (amount * SimpleTax * nInstallment);
            quota = quota + quota * PaymentFee;
            return quota;
        }
    }
}
