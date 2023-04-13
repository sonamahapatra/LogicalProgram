using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Logical Program");
            Console.WriteLine("Please Chhose One From Below Option: ");
            Console.WriteLine("1.PrimeNumber\n 2.Reverse Number");
            int Option = Convert.ToInt32(Console.ReadLine());   
            switch(Option)
            {
                case 1:
                    PrimeNumber.CheckPrime();
                    break;
                    case 2:
                    ReverseNumber.Display();
                    break;
                default:
                    Console.WriteLine("Please Choose program with given Option");
                    break;

            }
            Console.ReadLine();
}
    }
}
