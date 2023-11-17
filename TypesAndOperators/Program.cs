using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {

        Calculator();

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

    }
}