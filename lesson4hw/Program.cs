using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4hw
{
    class Program
    {
        static void Main(string[] args)
        {
            //take a number and display it only if number is bigger then 938 or smaller then 532
            Console.WriteLine("please enter a number");
            int theNum = int.Parse(Console.ReadLine());
            if ((theNum > 938) || (theNum < 532))
            {
                Console.WriteLine("good, the number is {0}", theNum);
            }
            else
                Console.WriteLine("no good");

            //take a number and say if its odd or even number
            Console.WriteLine("please enter another number");
            int newNum = int.Parse(Console.ReadLine());
            if ((newNum % 2) == 0)
                Console.WriteLine("the number is even");
            else
                Console.WriteLine("the number is odd");

            //enter 3 numbers and return them in order
            Console.WriteLine("enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int maxNum;
            int minNum;
            int middleNum = 0;
            //lets find the max number
            if (a > b)
                maxNum = a;
            else
                maxNum = b;
            if (c > maxNum)
                maxNum = c;

            //lets find the min number

            if (a < b)
                minNum = a;
            else
                minNum = b;
            if (c < minNum)
                minNum = c;

            //lets find the middle number
            if ((maxNum > a) && (minNum < a))
                middleNum = a;
            else
                if ((maxNum > b) && (minNum < b))
                middleNum = b;
            else
                middleNum = c;

            Console.WriteLine("{0} {1} {2}", maxNum, middleNum, minNum);

            // enter a number and display all the numbers from one to the num
            Console.WriteLine("enter a number to count to");
            int myCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= myCount; i++)
                Console.WriteLine("{0}", i);

            // enter a number and display all the even numbers from 2 to the num
            Console.WriteLine("enter a number to count to with even numbers");
            int myEvenCount = int.Parse(Console.ReadLine());
            for (int i = 2; i <= myEvenCount; i = i + 2)
                Console.WriteLine("{0}", i);

            // enter 10 numbers and i will display the biggest one
            int maxOutofTen = 0;
            Console.WriteLine("enter 10 numbers and i will display the biggest one");
            for (int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > maxOutofTen)
                    maxOutofTen = x;
            }
            Console.WriteLine("the biggest bumber is {0}", maxOutofTen);

            // enter 10 numbers and i will display the smallest one
            int minOutofTen = 2147483647;
            Console.WriteLine("enter 10 numbers and i will display the smallest one");
            for (int i = 0; i < 10; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < minOutofTen)
                    minOutofTen = x;
            }
            Console.WriteLine("the smallest bumber is {0}", minOutofTen);

        }
    }
}
