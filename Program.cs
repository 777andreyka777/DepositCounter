using System;
using System.Diagnostics;

class DepositCounter
{
    static void Main(String[] args)
    {
        float money;
        int years;
        int YearsPersent;
        int PersentConverter = 100;

        Console.WriteLine("Какую сумму хотите инвестировать?: ");
        money = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("На сколько лет?: ");
        years = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Под какой процент: ");
        YearsPersent = Convert.ToInt32(Console.ReadLine());

        for(int i = 1;i <= years; i++)
        {
            money += money * YearsPersent / PersentConverter;
            Console.Write($"На {i} год твоя сумма составляет: {money}");
            Console.ReadKey();
            if( i == years)
            {
                Console.WriteLine("Срок вашего депозита истек!");
                break;
            }
        }
    }
}

