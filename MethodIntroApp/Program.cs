using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodIntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string aValue = GetData("Pavel","Fahmi");
            Console.WriteLine(aValue);

            int bValue=
        }
        //Method without parameter

        //static string Getdata()
        //{
        //    return "Hello world";
        //}

        //Method With Parameter
        static string GetData(string firstString, string secondString)
        {
            return firstString + " " + secondString;
        }

        static int AddData(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
