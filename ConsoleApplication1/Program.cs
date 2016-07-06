using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Computer
    {
        public int memory;
        public int disk;
        public string name;



        public Computer(int computermemory
                        , string computerName)
        {
            memory = computermemory;
            name = computerName;
        }

        public Computer(int computermemory
                        , int computerdisk
                        , string computerName)
        {
            memory = computermemory;
            disk = computerdisk;
            name = computerName;
        }

        public void PrintSpec()
           { 
             Console.WriteLine("Memory = {0}MB, Disk = {1}GB",memory,disk); 
           }

    }


class MainClass
    {

        static void Main()
        {
            Computer computer1;
            computer1 = new Computer(1000,"Sales01");
            Console.WriteLine("{0}", computer1.name);
            computer1.PrintSpec();

            Computer computer2;
            computer2 = new Computer(1600, 120, "Sales02");
            Console.WriteLine("{0}", computer2.name);
            computer2.PrintSpec();
        }
    }
}