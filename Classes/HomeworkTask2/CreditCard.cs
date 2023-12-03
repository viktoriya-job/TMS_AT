using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Homework
{
    internal class CreditCard
    {
        public const string lineSeparator = "______________________________";

        private string AccountNumber { get; set; }
        private float Amount { get; set; }

        public CreditCard(string accountNumber, float amount)
        {
            AccountNumber = accountNumber;
            Amount = amount;
        }

        string FormatMoney(float money) => String.Format("{0:C0}", money);

        public void GetInfo()
        {
            PrintInfo("",0);
        }

        internal void TopUpAccount(float sum)
        {
            if (CheckSum(sum))
            {
                Amount += sum;
                PrintInfo("Внесена сумма: ", sum);
            }
        }

        internal void TopDownAccount(float sum)
        {
            if (CheckSum(sum))
            {
                //Предполагаем, что кредитный лимит 0.00
                if (Amount - sum >= 0)
                {
                    Amount -= sum;
                    PrintInfo("Выдана сумма: ", sum);
                }
                else
                    Console.WriteLine("Операция не выполнена: баланса на счете недостаточно");
            }
        }

        private bool CheckSum(float sum)
        {
            if (sum > 0)
                return true;
            else
            {
                Console.WriteLine("Операция не выполнена: введена не положительная сумма");
                return false;
            }
        }
        private void PrintInfo(string? message, float sum)
        {
            if (String.IsNullOrWhiteSpace(message))
                Console.WriteLine($"""
                {lineSeparator}
                Номер счета: {AccountNumber}
                Текущий баланс: {FormatMoney(Amount)}
                {lineSeparator}
                """);
            else
                Console.WriteLine($"""
                {lineSeparator}
                Номер счета: {AccountNumber}
                {message} {FormatMoney(sum)}
                Текущий баланс: {FormatMoney(Amount)}
                {lineSeparator}
                """);
        }
    }
}
