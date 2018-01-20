using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Prime Numbers");
            
            Console.WriteLine(isPrime(2));
            Console.WriteLine(isPrime(21));
            Console.WriteLine(isPrime(23));
            Console.WriteLine(isPrime(159));
            // Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("Prime Factors");
            
            primeFactor(2);
            primeFactor(21);
            primeFactor(23);
            primeFactor(159);
            primeFactor(26);
            primeFactor(101148);

            Console.WriteLine("\n");
            Console.WriteLine("Reverse");
            Console.WriteLine("{0} reverse is {1}", 45, reversenum(45));
            Console.WriteLine("{0} reverse is {1}", 4565, reversenum(4565));
            Console.WriteLine("{0} reverse is {1}", 458978, reversenum(458978));

            Console.WriteLine("\n");
            Console.WriteLine("Palindrome");
            
            Palindrome(124);
            Palindrome(121);
            Palindrome(10001);
            Palindrome(100001);
            Console.WriteLine("\n");
            Console.WriteLine("Sum of Digits");
            sumofDigits(45654);
            sumofDigits(342);
            sumofDigits(6789);
            Console.ReadLine();

        }


        static bool isPrime(int num)
        {
            if (num == 2) return true;
            if (num % 2 == 0) return false;
            int largestfactor;
            //see if num is evenly divisible, i
            for (int i = 3; i < num / 2; i = i + 2)
            {
                if (num % i == 0)
                {
                    largestfactor = i;
                    //Console.WriteLine("Factor for {0} is {1}:", num, i);
                    return false; //if it is evenly divisible then it is not PRIME
                }
            }

            return true;

        }

        public static void primeFactor(int num)
        {
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0 && isPrime(i))
                {
                    Console.WriteLine("{0} : {1}", num, i);
                }
            }
        }

        public static int reversenum(int num)
        {
            int sum = 0;
            int temp;
            int rem;

            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                sum = sum * 10 + rem;
            }
            return sum;
        }

        static void Palindrome(int num)
        {
            if (num == reversenum(num))
                Console.WriteLine("The number {0} is Palindrome", num);
            else
                Console.WriteLine("The number {0} is NOT Palindrome", num);
        }

        public static void sumofDigits(int num)
        {
            int total = 0;
            int temp = num;
            while (num > 0)
            {
                total += num % 10;
                num = num / 10;
            }
            Console.WriteLine("Sum of Digits for given {0} is {1}", temp, total);
        }

    }
}
