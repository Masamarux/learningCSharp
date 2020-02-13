using System;
using System.Text;
using System.Collections.Generic;
using ContractQuotas.Interfaces;

namespace ContractQuotas.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();
        private IPaymentService _paymentService;

        public Contract(int number, DateTime date, double totalValue, IPaymentService paymentService)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            _paymentService = paymentService;
        }
        public void CreateInstallments(int nInstallment)
        {
            double grossQuota = TotalValue / nInstallment;

            for(int i = 0; i < nInstallment; i++)
            {
                Installments.Add(new Installment(Date.AddMonths(i + 1), i, grossQuota, _paymentService));
            }
        }
        public void RemoveInstallment(Installment installment)
        {
            Installments.Remove(installment);
        }
        public string ShowInstallments()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Installment inst in Installments)
            {
                sb.AppendLine(inst.ToString());
            }

            return sb.ToString();
        }
    }
}
