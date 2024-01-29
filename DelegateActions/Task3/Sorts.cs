namespace Delegate
{
    internal class Sorts
    {
        public int[] BubbleSort(int[] array)
        {
            int left = 0;

            while (left < array.Length)
            {
                for (int i = array.Length - 1; i > left; i--)
                    if (array[i] < array[i - 1])
                        Swap(ref array[i], ref array[i - 1]);
                left++;
            }
            return array;
        }

        public int[] ShakerSort(int[] array)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                for (int i = right; i > left; i--)
                    if (array[i] < array[i - 1])
                        Swap(ref array[i], ref array[i - 1]);
                left++;

                for (int i = left; i < right; i++)
                    if (array[i] > array[i + 1])
                        Swap(ref array[i], ref array[i + 1]);
                right--;
            }
            return array;
        }

        private void Swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
