using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        Calculator();
        DefineInterval();

        //Задание 1 - калькулятор
        static void Calculator()
        {
            Console.Write("Введите первое число:\t\t");
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите оператор (+ - * /)\t");
            char operat = Convert.ToChar(Console.ReadLine());

            if (operat != '+' && operat != '-' && operat != '*' && operat != '/')
                Console.WriteLine($"Ошибка: Введен некорректный оператор [{operat}]");

            else
            {
                Console.Write("Введите второе число:\t\t");
                float num2 = Convert.ToSingle(Console.ReadLine());

                if (operat == '/' && num2 == 0)
                    Console.WriteLine($"Ошибка: Попытка деления на 0");

                else
                {
                    Console.Write($"Результат:\t\t\t{num1}{operat}{num2}=");
                    switch (operat)
                    {
                        case '+':
                            Console.WriteLine(num1 + num2); break;

                        case '-':
                            Console.WriteLine(num1 - num2); break;

                        case '*':
                            Console.WriteLine(num1 * num2); break;

                        case '/':
                            Console.WriteLine(num1 / num2); break;

                        default:
                            Console.WriteLine("Непредвиденная ошибка"); break;
                    }
                }
            }
        }

        //Задание 2 - определить, из какого интервала введенное число
        static void DefineInterval()
        {
            Console.Write("Введите целое число из интервала [-50;50]:\t");

            //предполагаем, что число целое
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < -50 || num > 50)
                Console.WriteLine($"Введенное число {num} не входит в проверяемый интервал [-50,50]");

            else if (num >= -40 && num <= -10)
                Console.WriteLine($"Число {num} входит в интервал [-40,-10]");

            else if (num >= -9 && num <= 0)
                Console.WriteLine($"Число {num} входит в интервал [-9,0]");

            else if (num >= 1 && num <= 10)
                Console.WriteLine($"Число {num} входит в интервал [1,10]");

            else if (num >= 11 && num <= 40)
                Console.WriteLine($"Число {num} входит в интервал [11,40]");

            else
                Console.WriteLine($"Число {num} не входит ни в один из интервалов  [-40,-10];[-9,0];[1,10];[11,40]");

        }

    }
}