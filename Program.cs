using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;
            int OPS;
            Console.WriteLine("enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter second number");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("main menu");
            Console.WriteLine("1.addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multplication");
            Console.WriteLine("4.division");
            Console.WriteLine("please select one of the above operators 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division ");

            OPS = int.Parse(Console.ReadLine());
            if (OPS == 1)
            {
                result = Add(num1, num2);
            }
            else if (OPS == 2)

            {
                result = subtract(num1, num2);
            }
            else if (OPS == 3)
            {
                result = multiplay(num1, num2);
            }
            else if (OPS == 4)
            {
                result = divide(num1, num2);

            }
            else
            {
                Console.WriteLine("pleas enter the number from 1 to 4");
                result = 0;
            }

            Console. WriteLine("the result is {0} " + result);
            Console.ReadLine();
        }

        private static int divide(object num2)
        {
            throw new NotImplementedException();
        }

        static int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        static int subtract(int n1, int n2)
        {
            return n1 - n2;
        }
        static int multiplay(int n1, int n2)
        {
            return n1 * n2;
        }
        static int divide(int n1, int n2)
        {
            if (n2 == 0) 
            {
                Console.WriteLine("please correct num1");
                return n1;
            }
              else
                return  n1 / n2;
        }


    }        









 } 
               
    


