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
            Driver driver = new Driver();
            driver.Name = "Roman";
            WorkCard workCard = new WorkCard(driver.Name, 8);
            workCard.StartJob();
            workCard.EndJob();
            Console.Read();
        }
    }
}
