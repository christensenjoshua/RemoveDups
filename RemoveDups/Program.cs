using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDups
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 1, 3, 1, 4, 2, 3, 6 };
            int[] nonDups = RemoveDups(arr);
            for(int i = 0; i < nonDups.Length; i++)
            {
                Console.WriteLine(nonDups[i]);
            }
            Console.ReadLine();
        }
        private static int[] RemoveDups(int[] nums)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            Dictionary<int, int> found = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int thisNum = nums[i];
                if(found.ContainsKey(thisNum))
                {
                    numbers.Remove(thisNum);
                }
                else
                {
                    found.Add(thisNum, thisNum);
                    numbers.Add(thisNum, thisNum);
                }
            }
            return numbers.Values.ToArray();
        }
    }
}
