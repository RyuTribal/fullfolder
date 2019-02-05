using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dagens-uppgift-3
{
    class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Choose assigment from A to F");
        string assigment = Console.ReadLine();
        string switching = assigment.ToLower();

        switch (switching)
        {
            case "a":

                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("Hey " + name + "!");
                break;

        }

    }
}
}
