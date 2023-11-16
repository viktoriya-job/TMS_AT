using System.Runtime.Serialization;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        const int MINUTES_IN_HOUR = 60;
        string name = "Vika";
        Console.WriteLine($"Hello {name} \t How are you? \n Great!");

        var flag = false;
        var i = 10.0;
        var fl = 10.1;

        int j = Convert.ToInt32(i);
        */


        //Решение задачи: купить продукты, купить мороженое, если хватит остатка
        //Подготовка данных

        //Свойства хлеба
        bool isWhiteBradFresh = true;
        ushort whiteBredPrice = 150;

        //Свойства масла
        ushort butterPrice = 230;

        //Свойства молока
        ushort milkPrice = 170;
        float milkFatPercentage = 1.2f;

        //
        ushort icecreamPrice = 170;

        Console.Write("Введите начальную сумму: ");
        string? sumString = Console.ReadLine();  // может быть введено mull
        short sum = Convert.ToInt16(sumString);

        if (sum > 0)
        {
            if (!isWhiteBradFresh)
            {
                Console.WriteLine("Хлеб не свежий(");
            }
            else if
            {
                if (sum >= whiteBredPrice)
                { 
                    sum = Convert.ToInt16(sum - whiteBredPrice); 
                }
                else 
                {
                    Console.WriteLine("На хлеб денег не хватает");
                }
               
            }

            sum = (short)(sum - butterPrice);

            if (milkFatPercentage == 1.2f)
            {
                sum = Convert.ToInt16(sum - milkPrice);
            }

            if (sum >= icecreamPrice)
            {
                Console.WriteLine("Ура! Можно купить мороженое!"); 
                sum = Convert.ToInt16(sum - icecreamPrice);
            }
            Console.WriteLine($"Остаток суммы: {sum}");
        }

        else
        {
            Console.WriteLine($"Сумма должна быть положительной ");
        }

 

    }
}