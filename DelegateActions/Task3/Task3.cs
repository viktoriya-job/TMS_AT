namespace Delegate
{
    internal class Task3
    {
        public delegate int[] Sort(int[] array);
        Sorts sorts = new Sorts();

        Sort SelectSort(SortType sortType)
        {
            switch (sortType)
            {
                case SortType.BubbleSort: return sorts.BubbleSort;
                default: return sorts.ShakerSort;
            }
        }
        public void Run()
        {
            Random random = new Random();
            int[] array = new int[10];
            int[] array2 = new int[10];

            Console.WriteLine("Исходный массив 1");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(10);
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine("\nОтсортированный массив: выбрана пузырьковая сортировка");

            Sort sort1 = SelectSort(SortType.BubbleSort);
            sort1(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            Console.WriteLine("\n\nИсходный массив 2");

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(10);
                Console.Write($"{array2[i]} ");
            }

            Console.WriteLine("\nОтсортированный массив: выбрана шейкерная сортировка");

            Sort sort2 = SelectSort(SortType.ShakerSort);
            sort2(array2);

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");
        }
    }
}
