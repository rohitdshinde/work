using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    internal class Program
    {
        void Display()
        { 
        Console.WriteLine("welcome");
        }
        static void Main(string[] args)
        {
        Program p = new Program();
        p.Display();
        Console.ReadLine();
        }
    }
}
