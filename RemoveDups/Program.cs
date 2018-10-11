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
            HashSet<int> goodNumbers = new HashSet<int>();
            HashSet<int> found = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int thisNum = nums[i];
                if(found.Contains(thisNum))
                {
                    goodNumbers.Remove(thisNum);
                }
                else
                {
                    found.Add(thisNum);
                    goodNumbers.Add(thisNum);
                }
            }
            return goodNumbers.ToArray();
        }
    }
}
