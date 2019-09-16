// Luke Ott
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework._2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double accounting;
            double marketing;
            double economics;
            double MIS;
            

            double gpa;
            
            double accgrade;
            double markgrade;
            double ecograde;
            double misgrade;
            
            Console.WriteLine("What is your grade percentage for accounting?");
            accounting = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your grade percentage for marketing?");
            marketing = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your grade percentage for economics?");
            economics = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your grade percentage for MIS?");
            MIS = Convert.ToDouble(Console.ReadLine());
            
            if (accounting >= 90)
            {
               
                accgrade = 12;
            }
            else if (accounting <= 89.99 || accounting >= 80)
            {
                accgrade = 9;
            }
            else if (accounting <= 79.99 || accounting >= 70)
            {
                accgrade = 6;
            }
            else if (accounting <= 69.99 || accounting >= 60)
            {
                accgrade = 3;
            }
           
            else
            {
                accgrade = 0;
            }
            if (marketing >= 90)
            {
                markgrade = 12;
            }
            else if (marketing <= 89.99 || marketing >= 80)
            {
                markgrade = 9;
            }
            else if (marketing <= 79.99 || marketing >= 70)
            {
                markgrade = 6;
            }
            else if (marketing <= 69.99 || marketing >= 60)
            {
                markgrade = 3;
            }
            else
            {
                markgrade = 0;
            }
            if (economics >= 90)
            {
                ecograde = 12;
            }
            else if (economics <= 89.99 || economics >= 80)
            {
                ecograde = 9;
            }
            else if (economics <= 79.99 || economics >= 70)
            {
                ecograde = 6;
            }
            else if (economics <= 69.99 || economics >= 60)
            {
                ecograde = 3;
            }
            else
            {
                ecograde = 0;
            }
            if (MIS >= 90)
            {
                misgrade = 12;
            }
            else if (MIS <= 89.99 || MIS >= 80)
            {
                misgrade = 9;
            }
            else if (MIS <= 79.99 || MIS >= 70)
            {
                misgrade = 6;
            }
            else if (MIS <= 69.99 || MIS >= 60)
            {
                misgrade = 3;
            }

            else
            {
                misgrade = 0;
            }
            gpa = (accgrade + markgrade + ecograde + misgrade) / 12;
           
            Console.WriteLine("Your GPA for the semester is " + gpa);
            Console.ReadKey();
        }
    }
}
