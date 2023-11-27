using System.Text;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;

        Console.WriteLine("""
            Выберите операцию:" +
                0 - Калькулятор
                1 - Определение интервала числа
                2 - Переводчик
                3 - Проверка числа на четность, алгоритм 1
                4 - Проверка числа на четность, алгоритм 2
                5 - Проверка числа на четность, алгоритм 3
            """);
        byte func = Convert.ToByte(Console.ReadLine());

        if (func > 5)
        {
            Console.WriteLine("Вы ввели неправильный номер операции =(");
        }
        else
        {
            switch (func)
            {
                case 0: Calculator(); break;

                case 1: DefineInterval(); break;

                case 2: Dictionary(); break;

                case 3: Parity1(); break;

                case 4: Parity2(); break;

                case 5: Parity3(); break;
            }
        }

        //Задание 1 - калькулятор
        static void Calculator()
        {
            Console.Write("""
                Введите первое число:       
                """);
            float num1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("""
                Введите оператор (+ - * /): 
                """);
            char operat = Convert.ToChar(Console.ReadLine());

            if (operat != '+' && operat != '-' && operat != '*' && operat != '/')
                Console.WriteLine($"Ошибка: Введен некорректный оператор [{operat}]");

            else
            {
                Console.Write("""
                Введите второе число:       
                """);
                float num2 = Convert.ToSingle(Console.ReadLine());

                if (operat == '/' && num2 == 0)
                    Console.WriteLine("Ошибка: Попытка деления на 0");

                else
                {
                    Console.Write($"""
                        Результат:                  
                        """);
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

        //Задание 3 - переводчик с русского на английский
        static void Dictionary()
        {
            Console.Write("Введите слово на русском языке: ");
            string russianWord = Console.ReadLine();

            Console.Write("""
                Русский яз.		Английский яз.
                {russianWord}           
                """);

            switch (russianWord)
            {
                case "тепло":
                    Console.WriteLine("warm"); break;

                case "холодно":
                    Console.WriteLine("cold"); break;

                case "мороз":
                    Console.WriteLine("frosty"); break;

                case "снег":
                    Console.WriteLine("snow"); break;

                case "дождь":
                    Console.WriteLine("rain"); break;

                case "ветер":
                    Console.WriteLine("wind"); break;

                case "гроза":
                    Console.WriteLine("storm"); break;

                case "туман":
                    Console.WriteLine("fog"); break;

                case "облачно":
                    Console.WriteLine("cloudy"); break;

                case "жарко":
                    Console.WriteLine("hot"); break;

                default:
                    Console.WriteLine("слово отсутствует в словаре"); break;
            }
        }

        //Задание 4 - определить четность число. Алгоритм 1
        static void Parity1()
        {
            Console.Write("Введите целое число: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
                Console.WriteLine($"Число {num} - четное");
            else
                Console.WriteLine($"Число {num} - нечетное");
        }

        //Задание 4 - определить четность число. Алгоритм 2
        static void Parity2()
        {
            Console.Write("Введите целое число: ");

            int num = Convert.ToInt32(Console.ReadLine());

            if (num / 2 * 2 == num)
                Console.WriteLine($"Число {num} - четное");
            else
                Console.WriteLine($"Число {num} - нечетное");
        }

        //Задание 4 - определить четность число. Алгоритм 3
        static void Parity3()
        {
            Console.Write("Введите целое число: ");

            int num = Convert.ToInt32(Console.ReadLine());
            int numAbs = Math.Abs(num);

            //Получим последнюю цифру модуля числа и проверим, делится ли она на 2
            if (numAbs % 10 == 0 || numAbs % 10 == 2 || numAbs % 10 == 4 || numAbs % 10 == 6 || numAbs % 10 == 8)
                Console.WriteLine($"Число {num} - четное");
            else
                Console.WriteLine($"Число {num} - нечетное");
        }
    }
}