
using System.Text.RegularExpressions;

namespace Exceptions
{
    internal class Task1
    {
        public static void Run()
        {
            try
            {
                Console.Write("Введите логин: ");
                string? login = Console.ReadLine();

                Console.Write("Введите пароль: ");
                string? password = Console.ReadLine();

                Console.Write("Введите пароль повторно: ");
                string? confirmPassword = Console.ReadLine();

                if (IsCorrectRegistrationData(login, password, confirmPassword))
                    Console.WriteLine("Все данные корректны");
            }
            catch (WrongLoginException exLogin)
            {
                Console.WriteLine($"Ошибка при вводе логина: {exLogin.Message}");
            }
            catch (WrongPasswordException exPassword)
            {
                Console.WriteLine($"Ошибка при вводе пароля: {exPassword.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        private static bool IsCorrectRegistrationData(string? login, string? password, string? confirmPassword)
        {
            bool result = true;

            if (String.IsNullOrWhiteSpace(login))
            {
                result = false;
                throw new WrongLoginException("Задана пустая строка");
            }
            if (login.Length >= 20)
            {
                result = false;
                throw new WrongLoginException("Логин должен содержать меньше 20 символов");
            }
            if (IsContainsWhiteSpace(login))
            {
                result = false;
                throw new WrongLoginException("Логин содержит пробелы");
            }
            if (String.IsNullOrWhiteSpace(password))
            {
                result = false;
                throw new WrongPasswordException("Задана пустая строка");
            }
            if (password.Length >= 20)
            {
                result = false;
                throw new WrongPasswordException("Пароль должен содержать меньше 20 символов");
            }
            if (IsContainsWhiteSpace(password))
            {
                result = false;
                throw new WrongPasswordException("Пароль содержит пробелы");
            }
            if (!IsContainsNumber(password))
            {
                result = false;
                throw new WrongPasswordException("Пароль не содержит цифру");
            }
            if (password != confirmPassword)
            {
                result = false;
                throw new WrongPasswordException("Пароли не совпадают");
            }
            return result;
        }

        private static bool IsContainsWhiteSpace(string input)
        {
            return Regex.IsMatch(input, @"\s+");
        }

        private static bool IsContainsNumber(string input)
        {
            return Regex.IsMatch(input, @"\d");
        }
    }
}
