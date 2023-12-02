using Classes.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Homework
{
    internal class Banknote
    {
        public int Nominal;
        public int Count;

        public Banknote(int nominal)
        {
            Nominal = nominal;
        }
    }
    internal class CashMachine
    {
        Banknote banknote20 = new Banknote(20);
        Banknote banknote50 = new Banknote(50);
        Banknote banknote100 = new Banknote(100);

        public CashMachine(int banknote20Count, int banknote50Count, int banknote100Count)
        {
            banknote20.Count = banknote20Count;
            banknote50.Count = banknote50Count;
            banknote100.Count = banknote100Count;
        }

        private int GetSum(int nominal)
        {
            return nominal switch
            {
                20 => banknote20.Count * banknote20.Nominal,
                50 => banknote50.Count * banknote50.Nominal,
                100 => banknote100.Count * banknote100.Nominal,
                _ => 0
            };
        }

        private int GetTotalSum() => GetSum(20) + GetSum(50) + GetSum(100);

        private string FormatMoney(int money) => String.Format("{0:C0}", money);

        public void GetInfo()
        {
            Console.WriteLine($"""
                {CreditCard.lineSeparator}
                Информация о банкомате
                
                Доступная сумма: {FormatMoney(GetTotalSum())}

                В купюрах:
                        номиналом 20:   {FormatMoney(GetSum(20))}
                        номиналом 50:   {FormatMoney(GetSum(50))}
                        номиналом 100:  {FormatMoney(GetSum(100))}
                {CreditCard.lineSeparator}
                """);
        }

        public void DepositMoney(int banknote20Count, int banknote50Count, int banknote100Count)
        {
            //При попытке внести 0 или меньше купюр возвращаем ошибку
            if (banknote20Count < 0
                || banknote50Count < 0
                || banknote100Count < 0
                || banknote20Count + banknote50Count + banknote100Count == 0)
                Console.WriteLine("Операция не выполнена: попытка внести 0 или меньше купюр");
            else
            {
                banknote20.Count += banknote20Count;
                banknote50.Count += banknote50Count;
                banknote100.Count += banknote100Count;
                Console.WriteLine($"""
                            Операция выполнена успешно. Зачислено {FormatMoney(20 * banknote20Count + 50 * banknote50Count + 100 * banknote100Count)}
                            """);
            }
        }

        public bool WithdrawMoney(int withdrawalAmount)
        {
            if (withdrawalAmount <= 0)
            {
                Console.WriteLine($"""
                    Операция не выполнена.

                    Введена не положительная сумма {FormatMoney(withdrawalAmount)}
                    """);
                return false;
            }
            else if (withdrawalAmount > GetTotalSum())
            {
                Console.WriteLine($"""
                    Операция не выполнена.

                    Доступно: {FormatMoney(GetTotalSum())}
                    Запрошено: {FormatMoney(withdrawalAmount)}
                    """);
                return false;
            }
            else
            {
                int banknote20Count, banknote50Count, banknote100Count;

                if (DevideAmount(withdrawalAmount, out banknote20Count, out banknote50Count, out banknote100Count))
                {
                    banknote20.Count -= banknote20Count;
                    banknote50.Count -= banknote50Count;
                    banknote100.Count -= banknote100Count;

                    Console.WriteLine($"""
                    Выдача наличных: {FormatMoney(withdrawalAmount)}

                    Банкнот номинала 20:    {banknote20Count}   на сумму    {FormatMoney(banknote20Count * 20)} 
                    Банкнот номинала 50:    {banknote50Count}   на сумму    {FormatMoney(banknote50Count * 50)} 
                    Банкнот номинала 100:   {banknote100Count}  на сумму    {FormatMoney(banknote100Count * 100)}

                    """);
                    return true;
                }
                else
                {
                    Console.WriteLine($"""
                            Операция не выполнена.

                            На текущий момент в банкомате отсутствуют купюры для выдачи суммы {FormatMoney(withdrawalAmount)}
                            """);
                    GetInfo();
                }
                return false;
            }
        }

        //Алгоритм разложения суммы на доступные купюры
        private bool DevideAmount(int amount, out int banknote20Count, out int banknote50Count, out int banknote100Count)
        {
            banknote20Count = banknote50Count = banknote100Count = 0;

            if (amount == 0)
                return true;

            //////////////////////////////////////////////  
            ///Пока не придумала, как вынести в цикл перебор всех типов банкнот. Перебираем линейно

            //Определим количество банкнот номинала 100
            //Проверим, есть ли столько банкнот в банкомате, и возьмем меньшее из сравниваемых значений
            banknote100Count = Math.Min(amount / banknote100.Nominal, banknote100.Count);
            amount = amount - banknote100Count * banknote100.Nominal;

            //Если сумма полностью разложена, выходим с положительным результатом
            if (amount == 0)
                return true;

            //Определим количество банкнот номинала 50
            //Проверим, есть ли столько банкнот в банкомате, и возьмем меньшее из сравниваемых значений
            banknote50Count = Math.Min(amount / banknote50.Nominal, banknote50.Count);
            amount = amount - banknote50Count * banknote50.Nominal;

            //Если сумма полностью разложена, выходим с положительным результатом
            if (amount == 0)
                return true;

            //Определим количество банкнот номинала 20
            //Проверим, есть ли столько банкнот в банкомате, и возьмем меньшее из сравниваемых значений
            banknote20Count = Math.Min(amount / banknote20.Nominal, banknote20.Count);
            amount = amount - banknote20Count * banknote20.Nominal;

            //Если сумма полностью разложена, выходим с положительным результатом
            if (amount == 0)
                return true;

            //Если к текущему моменту не вышли, значит сумма полностью не разложена
            //Выходим с отрицательным результатом
            return false;
        }
    }
}
