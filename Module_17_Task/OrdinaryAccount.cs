using Module_17_Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Module_17_Task.InitalData;

namespace Module_17_Task
{
    public class OrdinaryAccount : IAllAccounts
    {
        public void CalculateInterest()
        {
            Console.WriteLine("Расчет процентной ставки обычного аккаунта по правилам банка ");
            Console.WriteLine("Подробная инструкция находится в class OrdinaryAccount");

            void CalculateInterest(Account account)
            {
                {
                    if (account.Type == "Обычный")
                    {
                        account.Interest = account.Balance * 0.4;

                        if (account.Balance < 1000)
                            account.Interest -= account.Balance * 0.2;

                        if (account.Balance < 50000)
                            account.Interest -= account.Balance * 0.4;
                    }
                }
            }
        }
    }
}
