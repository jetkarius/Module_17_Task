using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_17_Task;
using System;

namespace Module_17_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var initalData = new InitalData();

            // аккаунт с обычным типом
            initalData.PerformAccount(new OrdinaryAccount());
            Console.WriteLine();

            // аккаунт с зарплатным типом
            initalData.PerformAccount(new SalaryAccount());
            Console.WriteLine();
        }
    }
}