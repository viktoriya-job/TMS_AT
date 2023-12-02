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

        private string AccountNumber;
        private float Amount;

        public CreditCard(string accountNumber, float amount)
        {
            AccountNumber = accountNumber;
            Amount = amount;
        }

        string FormatMoney(float money) => String.Format("{0:C0}", money);

        public void GetInfo()
        {
            Console.WriteLine($"""
                {lineSeparator}
                Номер счета: {AccountNumber}
                Текущий баланс: {FormatMoney(Amount)}
                {lineSeparator}
                """);
        }

        internal void TopUpAccount(float sum)
        {
            if (sum > 0)
            {
                Amount += sum;
                Console.WriteLine($"""
                        {lineSeparator}
                        Счет: {AccountNumber}
                        Внесена сумма: {FormatMoney(sum)}
                        Баланс: {FormatMoney(Amount)}
                        {lineSeparator}
                        """);
            }
            else
                Console.WriteLine($"""
                    {lineSeparator}
                    Счет: {AccountNumber}
                    Операция не выполнена: введена не положительная сумма   {FormatMoney(sum)}
                        Текущий баланс: {FormatMoney(Amount)}
                    {lineSeparator}
                    """);
        }

        internal void TopDownAccount(float sum)
        {
            if (sum > 0)
            {
                //Предполагаем, что кредитный лимит 0.00
                if (Amount - sum >= 0)
                {
                    Amount -= sum;
                    Console.WriteLine($"""
                        {lineSeparator}
                        Счет: {AccountNumber}
                        Выдана сумма: {FormatMoney(sum)}
                        Баланс: {FormatMoney(Amount)}
                        {lineSeparator}
                        """);
                }
                else
                    Console.WriteLine($"""
                        {lineSeparator}
                        Счет: {AccountNumber}
                        Операция не выполнена: баланса на счете недостаточно для выдачи суммы   {FormatMoney(sum)}
                            Текущий баланс: {FormatMoney(Amount)}
                        {lineSeparator}
                        """);
            }
            else
                Console.WriteLine($"""
                    {lineSeparator}
                    Счет: {AccountNumber}
                    Операция не выполнена: введена не положительная сумма   {FormatMoney(sum)}
                        Текущий баланс: {FormatMoney(Amount)}
                    {lineSeparator}
                    """);
        }
    }
}
