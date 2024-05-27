using System;
using System.Drawing;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------ TASK 1 ------------");
        Console.WriteLine("------------ TASK 2 ------------");
            for (int index = 0; index <= 20; index++)
            {
                if(index % 2 != 0)
                {
                    continue;
                }
                
                Console.WriteLine("{0}",index);
            }
        Console.WriteLine("------------ TASK 3 ------------");
        int result = 0;
        int multiplication = 1;
        do
        {
            for (int index = 0; index <= 10; index++)
            {
                if (index == 0)
                {
                    Console.WriteLine("### multiplication by {0} ###", multiplication);
                }
                Console.WriteLine("{2} * {1} = {0}",index * multiplication, index, multiplication);
            }
            multiplication++;
            result++;
        } while (result < 5);
        Console.WriteLine("------------ TASK 4 ------------");
        Console.WriteLine("enter the password:  ");
        string password = "qwerty";
        bool unlock = false;
        do
        {
            string right = Console.ReadLine();
            if (right == password)
            {
                unlock = true;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("incorrect password!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        } while (unlock == false);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Corrent password!");

    }

}

