using System;
using System.Collections.Generic;
using System.Text;

namespace ContractQuotas.Interfaces
{
    interface IPaymentService
    {
        double QuotaCalc(double amount, int nInstallment);
    }
}
