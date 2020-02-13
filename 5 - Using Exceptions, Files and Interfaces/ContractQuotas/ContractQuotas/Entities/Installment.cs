using System;
using System.Globalization;
using ContractQuotas.Interfaces;

namespace ContractQuotas.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Quota { get; set; }

        public Installment(DateTime dueDate, int nIntallment, double amount, IPaymentService paymentService)
        {
            DueDate = dueDate;
            Quota = paymentService.QuotaCalc(amount, nIntallment);
        }

        public override string ToString()
        {
            return  DueDate.ToString("dd/MM/yyyy")
                    + " - $ "
                    + Quota.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
