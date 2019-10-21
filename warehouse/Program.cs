using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkCard workCard = new WorkCard("Roman", 8);
            Driver driver = new Driver();
            driver.Work();
            driver.Brake();
            workCard.StartJob();
            workCard.EndJob();
            Console.Read();
        }
    }
}
