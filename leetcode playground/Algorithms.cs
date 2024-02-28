using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_playground
{
    public static class Algorithms
    {
        /// <summary>
        /// Perform binary search on an input array and returns the index of the target if it exists, otherwise returns -1.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int BinarySearch(int[] array, int target)
        {
            int L = 0;
            int R = array.Length - 1;

            while(L <= R)
            {
                int mid = (L + R) / 2;
                if (array[mid] < target)
                    L = mid + 1;
                else if (array[mid] > target)
                    R = mid - 1;
                else
                    return mid;
            }
            return -1;
        }

        private static int guess(int num)
        {
            int pick = 1702766719;
            if (num > pick)
                return -1;
            else if (num < pick)
                return 1;
            else
                return 0;
        }

        public static int GuessNumber(int upperBound)
        {
            long low = 0;
            long high = upperBound;

            while(true)
            {
                long mid = (low + high) / 2;
                int isCorrect = guess((int)mid);

                switch(isCorrect)
                {
                    case 0:
                        return (int)mid;
                    case 1:
                        low = mid + 1;
                        break;
                    case -1:
                        high = mid - 1;
                        break;
                }
                if (isCorrect > 0)
                    low = mid + 1;
                else if (isCorrect < 0)
                    high = mid - 1;
                else
                    return (int)mid;

            }
        }
    }
}
