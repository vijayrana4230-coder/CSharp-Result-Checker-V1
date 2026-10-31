using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace result_checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int a, b, c, d, e;
            string key;
            do
            {
                Console.WriteLine("****************************************** RESULT CHECKER ******************************************");
                Console.Write("Enter your name = ");
                name = Console.ReadLine();
                Console.WriteLine("****************************************** ENTER YOUR SUBJECT MARKS ******************************************");
                do
                {
                   
                    Console.Write("Enter Hindi Marks = ");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a < 0 || a > 100)
                    {
                        Console.Write("invailed marks enter marks between 0 to 100 \n");
                    }
                } while (a < 0 || a > 100);
                do
                {
                    Console.Write("Enter physics Marks = ");
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b < 0 || b > 100)
                    {
                        Console.Write("invailed marks enter marks between 0 to 100 \n");
                    }
                } while (b < 0 || b > 100);
                do
                {
                    Console.Write("Enter chemistry Marks = ");
                    c = Convert.ToInt32(Console.ReadLine());
                    if (c < 0 || c > 100)
                    {
                        Console.Write("invailed marks enter marks between 0 to 100 \n");
                    }
                } while (c < 0 || c > 100);
                do
                {
                    Console.Write("Enter math Marks = ");
                    d = Convert.ToInt32(Console.ReadLine());
                    if (d < 0 || d > 100)
                    {
                        Console.Write("invailed marks enter marks between 0 to 100 \n");
                    }
                } while (d < 0 || d > 100);
                do
                {
                    Console.Write("Enter English Marks = ");
                    e = Convert.ToInt32(Console.ReadLine());
                    if (e < 0 || e > 100)
                    {
                        Console.Write("invailed marks enter marks between 0 to 100 \n");
                    }
                } while (e < 0 || e > 100);
                    Console.WriteLine("****************************************** STUDENT DETAILS ******************************************");
                    Console.WriteLine("STUDENT NAME = " +name);
                    int total = a + b + c + d + e;
                    double per = total / 5;
                    Console.WriteLine("total marks = " + total + "/500");
                    Console.WriteLine("percentage = " + per + "%");
                 if (a < 33 || b < 33 || c < 33 || d < 33 || e < 33)
                {
                    Console.WriteLine("sorry you are fail");
                }
                else if (per >= 90)
                {
                    Console.WriteLine("A grade");
                }
                else if (per >= 80)
                {
                    Console.WriteLine("B grade");
                }
                else if (per >= 70)
                {
                    Console.WriteLine("C grade");
                }
                else if (per >= 33)
                {
                    Console.WriteLine("D grade");
                }
                else
                {
                    Console.WriteLine("fail");
                }
                    Console.WriteLine("try another plese enter yes/no");
                    key = Console.ReadLine();

            } while (key == "yes");
              Console.WriteLine("****************************************** THANK YOU ******************************************");
              Console.ReadLine();
        }
    }
}
