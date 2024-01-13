namespace Delegate
{
    internal class Sorts
    {
        public int[] BubbleSort(int[] array)
        {
            int step = 0;

            while (step < array.Length)
            {
                for (int i = array.Length-1; i > step; i--)
                    if (array[i] < array[i - 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;
                    }
                step++;
            }
            return array;
        }

        public int[] ShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length-1;

            while (left <= right) 
            { 
                for (int i = right; i > left; i--)
                    if (array[i] < array[i - 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i - 1];
                        array[i - 1] = tmp;
                    }
                left++;
                for (int i = left; i < right; i++)
                    if (array[i] > array[i + 1])
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }
                right--;
            }
            return array;
        }
    }
}
