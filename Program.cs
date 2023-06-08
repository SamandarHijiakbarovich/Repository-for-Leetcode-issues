using System.Collections.Specialized;

namespace Leetcode_Masala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int n=int.Parse(Console.ReadLine());
           // int.TryParse(Console.ReadLine(), out n);
             
            int[,] arr = new int[n,n];

            Random rand = new Random();

            for(int i=0;i<n;i++)
            {
                for(int j=0;j<n;j++)
                {
                    arr[i, j] = rand.Next(0,9);
                    Console.Write(arr[i, j]);
                    
                }
                Console.ReadLine();
            }*/

            // bu ham leetcode platformasidan masala
            /*           int n = int.Parse(Console.ReadLine());
                       int[] arr = new int[n];
                       Random rand = new Random();
                       for(int i=0;i<n;i++)
                       {
                           arr[i] = rand.Next(0, 9);
                           Console.Write(arr[i]);
                       }
                       Console.WriteLine();

                       int[] ar = new int[arr.Length];

                       for(int i=0;i<n;i++)
                       {
                           ar[i] += arr[i];

                           Console.Write(ar[i]);

                       }
                       Console.WriteLine();

                       ar[n - 1] = ar[n - 1] + 1;
                       for(int i=0;i<ar.Length;i++)
                       {
                           Console.Write(ar[i]);
                       }*/


            //69-masala letcodedan
            /*
                        int n = int.Parse(Console.ReadLine());

                        Console.WriteLine((int)Math.Sqrt(n));

            */


            //50-masala

            /*  double x = double.Parse(Console.ReadLine());
              int n = int.Parse(Console.ReadLine());

              double y = Math.Pow(x, n);
              Console.WriteLine(y);
  */


          /*  int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] arr = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next();
                Console.Write(arr[i]);
            }
            Console.WriteLine(RunningSum(arr));


            int[] RunningSum(int[] nums)
            {
                int[] arr = new int[nums.Length];
                int sum = 0;
                for (int i = 0; i < nums.Length; i++)
                {
                    sum += nums[i];
                    arr[i] += sum;
                }
                return arr;
            }*/


        }
    }
}