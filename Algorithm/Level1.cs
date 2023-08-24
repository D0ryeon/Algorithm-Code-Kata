using System.Security.Cryptography.X509Certificates;

namespace Algorithm
{
    internal class Program
    {
        public int a;

        static void Main(string[] args)
        {
           

            int[] a = { 1, 2, 3, 4 };
            Console.WriteLine("Level1 - 1 : " + solution1(1));
            Console.WriteLine("Level1 - 2 : " + solution2(a));
            Console.WriteLine("Level1 - 3 : " + solution3(123));
            Console.WriteLine("Level1 - 4 : " + solution4(122));
        }

        static string solution1(int num)
        {
            string answer = "Even";
            if (num % 2 == 0)
            {
                answer = "Even";
            }
            else
            {
                answer = "Odd";
            }
            return answer;
        }


        static double solution2(int[] arr)
        {
            double answer = 0;
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            answer = (double)sum / arr.Length;
            return answer;
        }

        static int solution3(int n)
        {
            int answer = 0;
            char[] chr = n.ToString().ToCharArray();

            foreach (char c in chr)
            {
                answer += Int32.Parse(c.ToString());
            }

            return answer;
        }

        static int solution4(int n)
        {
            int answer = 0;

            for (int i = 1; i <= n; i++)
            {
                if ((n % i == 0))
                {
                    answer += i;
                }
            }

            return answer;
        }
    }
}