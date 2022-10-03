namespace QuickSortOpgave
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new array containing 8 random numbers
            Random random = new Random();
            int[] intArr = new int[8];
            for (int i = 0; i < 8; i++)
            {
                intArr[i] = random.Next(100);
            }
            int arrLength = intArr.Length;
            String tekst = "Sort this Array";
            Console.WriteLine(tekst);
            PrintintArr(intArr, arrLength);

            SortintArr(intArr, 0, arrLength - 1);
            Console.WriteLine("The sorted array:");
            PrintintArr(intArr, arrLength);
        }

        //function that prints the array
        static void PrintintArr(int[] intArr, int size)
        {
            Console.Write(" ");
            for (int i = 0; i < size; i++)
                Console.Write(intArr[i] + " ");
            Console.WriteLine("\n");
        }

        //function that sorts the array by checking if the number is higher or lower than the pivot.
        //Then moves the number to the side of the array that fits to the place it needs to be.
        static int[] SortintArr(int[] intArr, int leftIndex, int rightIndex)
        {
            int left = leftIndex;
            int right = rightIndex;
            int pivot = intArr[leftIndex];
            while (left <= right)
            {
                while (intArr[left] < pivot)
                    left++;
                while (intArr[right] > pivot)
                    right--;

                if (left <= right)
                {
                    int temp = intArr[left];
                    intArr[left] = intArr[right];
                    intArr[right] = temp;
                    left++;
                    right--;
                }
            }

            if (leftIndex < right)
                SortintArr(intArr, leftIndex, right);
            if (left < rightIndex)
                SortintArr(intArr, left, rightIndex);
            return intArr;

        }



    }


}
