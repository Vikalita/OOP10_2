using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emploethis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            emploe worker = new emploe("Иван", -500);
            worker.Work();
            emploe worker1 = new emploe("Иван");
            worker1.Work();

        }
    }
}
