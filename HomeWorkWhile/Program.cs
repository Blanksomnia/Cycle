using System;
using System.Drawing;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------ TASK 1 ------------");
        int num1 = 0;
        int num2 = 1;
        int result;
        Console.WriteLine("0");
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(num2);
            result = num2;
            num2 = num2 + num1;
            num1 = result;
        }

        Console.WriteLine("------------ TASK 2 ------------");
        for(int index = 1; index <= 20; index++)
        {
            if(index % 2 != 0)
            {
                continue;
            }
                
            Console.WriteLine(index);
        }
        Console.WriteLine("------------ TASK 3 ------------");
        for(int a = 1; a <= 5; a++)
        {
            for (int b = 0; b <= 10; b++)
            {
                if (b == 0)
                {
                    Console.WriteLine("### multiplication by {0} ###", a);
                }
                Console.WriteLine("{2} * {1} = {0}", a * b, b, a);
            }
        }
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

