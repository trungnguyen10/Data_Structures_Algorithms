namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myNums = new int[] { 5, 7, 8, 2, 3, 12, 4, 0, -1, 1 };
            MergeSort(myNums, 0, 9);
            foreach (int element in myNums)
            {
                Console.Write(element + " ");
            }
        }

        static void Merge(int[] arr, int start, int end, int mid)
        {
            // create left array
            int LSize = mid - start + 1;
            int[] L = new int[LSize];
            for (int i = 0; i < LSize; i++)
            {
                L[i] = arr[i + start];
            }

            // create right array
            int RSize = end - mid;
            int[] R = new int[RSize];
            for (int i = 0; i < RSize; i++)
            {
                R[i] = arr[i + mid + 1];
            }

            // merge
            int LIndex = 0, RIndex = 0, ArrIndex = start;
            while (ArrIndex <= end)
            {
                if (R[RIndex] < L[LIndex])
                {
                    arr[ArrIndex] = R[RIndex];
                    RIndex++;
                    ArrIndex++;
                    if (RIndex == RSize) break;
                }
                else
                {
                    arr[ArrIndex] = L[LIndex];
                    LIndex++;
                    ArrIndex++;
                    if (LIndex == LSize) break;
                }
            }
            while (RIndex != RSize)
            {
                arr[ArrIndex] = R[RIndex];
                ArrIndex++;
                RIndex++;
            }
            while (LIndex != LSize)
            {
                arr[ArrIndex] = L[LIndex];
                ArrIndex++;
                LIndex++;
            }
        }

        static void Merge2(int[] arr, int start, int end, int mid)
        {
            // already sorted, return
            if (arr[mid] <= arr[mid + 1]) return;
            // otherwise
            int i = start, j = mid + 1;
            while (i < (mid + 1) && j < (end + 1))
            {
                if (arr[i] <= arr[j])
                    i++;
                else
                {
                    int key = arr[j];
                    for (int z = j; z > i; z--)
                    {
                        arr[z] = arr[z - 1];
                    }
                    arr[i] = key;
                    j++;
                    i++;
                    mid++;
                }
            }


        }
        static void MergeSort(int[] arr, int start, int end)
        {
            if (end > start)
            {
                int mid = (end + start) / 2;
                MergeSort(arr, start, mid);
                MergeSort(arr, mid + 1, end);
                Merge2(arr, start, end, mid);
            }
        }
    }
}