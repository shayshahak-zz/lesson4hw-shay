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
            int middleNum =0;
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
            if (((maxNum ==a) && (minNum==b)) || ((maxNum==b)  && (minNum==a)))
                middleNum = c;
            if (((maxNum == a) && (minNum == c)) || ((maxNum == c) && (minNum == a)))
                middleNum = b;
            if (((maxNum == b) && (minNum == c)) || ((maxNum == c) && (minNum == b)))
                middleNum = a;

            Console.WriteLine("{0} {1} {2}", maxNum, middleNum, minNum);
                                            

            }
        }
    }
