using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NumberGames
{
    class EmripNumber
    {
        /*
         * If a number is prime ( both forward and backward ) , it is called an Emrip number. 
         * 
        */
        public static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Enter the number : ");
            number = Convert.ToInt32(Console.ReadLine());
            if (isEmripOrNot(number)) { Console.WriteLine("{0} is an emrip number. ", number); }
            else { Console.WriteLine("{0} is not an emrip number. ", number); }

        }
        protected static bool isEmripOrNot(int number)
        {
            bool forwardEmrip = isPrimeOrNot(number);
            bool backEmrip = isPrimeOrNot(backwarding(number));
            
            return (forwardEmrip == backEmrip);

        }

        protected static bool isPrimeOrNot(int theNumber)
        {
            if (theNumber == 0 || theNumber == 1) return false;
            if (theNumber == 2) return true;
            bool isPrime = true;
            for(int i = 2; i < theNumber / 2; i++)
            {
                if (theNumber % i == 0)
                {
                    isPrime = !isPrime;
                    break;
                }
                
            }

            return isPrime;
        }


        protected static int backwarding(int theNumber)
        {
            if (theNumber <= 9) return theNumber;
            int backward = 0;
            while(theNumber != 0 && theNumber >= 9)
            {
                backward = backward + (theNumber % 10) * 10;
                theNumber /= 10;
                
            }
            backward += theNumber;
            return backward;
        }



    }
}
