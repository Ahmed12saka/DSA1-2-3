using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2_Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATM atm = new ATM();

            string menu = "Welcome to the ATM Machine!!!\n\n" +
                "PS. The algorithm is really really slow for some reason so please give it some time.\n" +
                "It won't print every possible option due to lack of NASA level of Computer Performence,\n" +
                "but I hope it is enough.\n" +
                "\n" +
                "Please enter amount you wish to withdraw:";

            Console.WriteLine(menu);
            int inputMoney = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter amount of maximum coins to be shown.");
            int inputAmountCoins = int.Parse(Console.ReadLine());
            Console.WriteLine("\n" +
                "Printing... Please wait!\n");

            atm.printAllOptions(inputMoney,inputAmountCoins, 0);
        }
    }
}
