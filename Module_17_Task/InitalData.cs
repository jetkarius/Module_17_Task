using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17_Task;

namespace Module_17_Task
{
    class InitalData
    {
        public class Account
        {
            public string Type { get; set; }

            public double Balance { get; set; }

            public double Interest { get; set; }
        }

        public void PerformAccount(IAllAccounts allAccounts)
        {
            allAccounts.CalculateInterest();
        }
    }
}
