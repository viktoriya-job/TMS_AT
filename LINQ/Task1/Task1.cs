using LINQ.Helper;

namespace LINQ
{
    internal class Task1
    {
        public static void Run()
        {
            List<int> _intList = new List<int>() {1, 2, 3, 1, 2, 3, 4, 5, 6, 4, 5, 6, 7, 7};

            var result = _intList.Where(number => number%2 != 0).Select(number => number).Distinct();
            
            PrintHelper.PrintCollection(result);
        }
    }
}
