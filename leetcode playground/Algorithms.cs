using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_playground
{
    public static class Algorithms
    {
        #region Private methods
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

        /// <summary>
        /// Split array into two halves and merge them into the input array, overwriting it with the sorted result.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="l"></param>
        /// <param name="m"></param>
        /// <param name="r"></param>
        private static void Merge(int[] array, int l, int m, int r)
        {
            int length1 = m - l + 1;
            int length2 = r - m;

            int[] L = new int[length1];
            int[] R = new int[length2];

            for (int i = 0; i < length1; i++)
                L[i] = array[l + 1];
            for (int j = 0; j < length2; j++)
                R[j] = array[m + 1 + j];

            int ii = 0;
            int jj = 0;
            int k = l;

            while (ii < length1 && jj < length2)
            {
                if (L[ii] <= R[jj])
                {
                    array[k] = L[ii];
                    ii++;
                }
                else
                {
                    array[k] = R[jj];
                    jj++;
                }
                k++;
            }

            while (ii < length1)
            {
                array[k] = R[ii];
                ii++;
                k++;
            }
            while (jj < length2)
            {
                array[k] = R[jj];
                jj++;
                k++;
            }
        }
        #endregion

        #region Public methods

        /// <summary>
        /// Sort an array with the Merge Sort algorithm using the left-most index l and right-most index r as parameters.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="l"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static int[] MergeSort(int[] array, int l, int r)
        {
            if(l < r)
            {
                int m = (l + r) / 2;
                MergeSort(array, l, m);
                MergeSort(array, m + 1, r);
                Merge(array, l, m, r);
            }
            return array;
        }

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

            while (L <= R)
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
        #endregion
    }
}
