namespace InsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNums = new int[] { 5, 7, 8, 2, 3, 12, 4, 0, -1 };
            Sort(myNums, myNums.Length);
            foreach (int element in myNums)
            {
                Console.Write(element + " ");
            }
        }

        static void Sort(int[] A, int size)
        {
            for (int i = 1; i < size; i++)
            {
                int key = A[i];
                int j = i - 1;
                while (j >= 0 && A[j] > key)
                {
                    A[j + 1] = A[j];
                    j--;
                }
                A[j + 1] = key;
            }
        }
    }
}