// Luke Ott
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string luckynum;
            int number;
            string output = "";
            
            Console.WriteLine("Please input your lucky number");
            luckynum = Console.ReadLine();
           
            bool verify = Int32.TryParse(luckynum, out number);
            if (verify == true)
            {
               
                if (number % 3 == 0 && number % 5 == 0)
                {
                    output = "FizzBuzz";
                }
                else if (number % 5 == 0)
                {
                    output = "Buzz";
                }
                else if (number % 3 == 0)
                {
                    output = "Fizz";
                }
                else
                {
                  
                    output = Convert.ToString(number);
                }

            }
            else
            {
                
                Console.WriteLine("Sorry, I am unable to run the FizzBuzz process because the number you inputted is not a valid");
                Console.ReadKey();
            }
            
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
