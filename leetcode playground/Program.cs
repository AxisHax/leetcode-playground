namespace leetcode_playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sortedArr = { 107, 133, 171, 199, 208, 221, 223, 225, 230, 416, 463, 509, 591, 631, 705, 773, 882, 917, 924, 1005 };
            int target = 1006;
            Node root = new Node(0);
            BinaryTree tree = new BinaryTree(root);

            printIntArray(sortedArr);
            Console.WriteLine("The location of {0} in the array is index {1}.", target, Algorithms.BinarySearch(sortedArr, target));
            Console.WriteLine("Guessing game!! You guessed {0}. I picked {1}.", Algorithms.GuessNumber(2126753390), 1702766719);
        }

        public static void printIntArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\n");
        }
    }
}