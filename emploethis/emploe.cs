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
            Name = name_emp;
            Solar = solar; 
        }
        public emploe(string name_emp)
        { 
            Name = name_emp;
            Solar = 50000;
        }
        //свойства
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Solar
        {
            get { return solary; }
            set 
            {
                if (value < 1 || value > 1000000)
                {
                    Console.WriteLine("Ошибка: в не диапозона.");
                    er_sol = true;
                }
                else
                { 
                    solary = value;
                    er_sol = false;
                }
            }
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
