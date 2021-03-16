using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab16zavd1
{
    class Program
    {
        struct PIP
        {
            public string fname;
            public string sname;
            public string father;
            public void Info()
            {
                Console.WriteLine($"Імя: {fname}  Фамілія: {sname}  Побатькові: {father}");
            }
        }

        static void Main(string[] args)
        {
            PIP pip;
            pip.fname = "Богдан";
            pip.sname = "Стицун";
            pip.father = "Андрійович";
            pip.Info();
            Console.ReadLine();
        }
    }
}
