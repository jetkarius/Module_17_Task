using Module_17_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;
using static Module_17_Task.InitalData;

namespace Module_17_Task
{
    public class SalaryAccount : IAllAccounts
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Расчет процентной ставки зарплатного аккаунта по правилам банка");
            Console.WriteLine("Подробная инструкция находится в class SalaryAccount");

            void CalculateInterest(Account account)
            {
                if (account.Type == "Зарплатный")
                {
                    account.Interest = account.Balance * 0.5;
                }
            }
        }
    }
}
