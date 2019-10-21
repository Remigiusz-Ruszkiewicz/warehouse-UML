using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace warehouse
{
    public class WorkCard
    {
        private string Name = "Elektryczny";
        private int HoursOfWork;
        public WorkCard(string name, int hours)
        {
            this.Name = name;
            HoursOfWork = hours;

        }
        public void StartJob()
        {
            Console.WriteLine(nameof(StartJob));
            Console.WriteLine((Name));
        }
        public void EndJob()
        {
            Console.WriteLine(nameof(EndJob));
            Console.WriteLine((Name));
        }
    }
}
