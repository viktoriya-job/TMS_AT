using Generics.Helper;

namespace Generics
{
    internal class Task2
    {
        public static void Run()
        {
            Random random = new Random();
            ArrayGeneric<int> arrayInt = new ArrayGeneric<int>(5);

            for (int i = 0; i < arrayInt.Length; i++)
            {
                arrayInt.ArrayValues[i] = random.Next(2);
            }

            Console.WriteLine("Созданный массив со значениями типа int:");
            PrintHelper.PrintArray(arrayInt.ArrayValues);

            Console.WriteLine($"Элемент массива по индексу 0: {arrayInt.GetByIndex(0)}, длина массива: {arrayInt.GetLenth()}\n");
            
            arrayInt.Add(random.Next(2));
            Console.WriteLine("Массив со значениями типа int после добавления нового элемента:");
            PrintHelper.PrintArray(arrayInt.ArrayValues);
 
            arrayInt.Remove(0);
            Console.WriteLine("Массив со значениями типа int после удаления значения 0:");
            PrintHelper.PrintArray(arrayInt.ArrayValues);
        }
    }
}