using System;
using System.Collections.Generic;
using System.Text;

namespace PolyPayroll
{
    public interface iPayable
    {
        decimal GetPaymentAmount();
    }
}
