using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emploethis
{
    internal class emploe
    {
        private string name;
        private double solary;
        private bool er_sol;
        //конструкторы
        public emploe(string name_emp,double solar)
        { 
            this.name = name_emp;
            if (solar < 1 || solar > 1000000)
            {
                Console.WriteLine("Ошибка: число не в диапозоне.");
                er_sol = true;
            }
            else
            {
                this.solary = solar;
            }
        }
        public emploe(string name_emp)
        { 
            this.name = name_emp;
            this.solary = 50000;
        }

        // действия
        public void Work()
        {
            if (er_sol == false)
            {
                Console.WriteLine($"{name} работает, зарплата {solary}");
            }
        }
    }
}
