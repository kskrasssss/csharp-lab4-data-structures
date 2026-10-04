using System;

namespace Lab4Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо по одному екземпляру кожного підтипу
            var success = new TransactionEvent.Success("TX-1001", 1500m);
            var insufficient = new TransactionEvent.InsufficientFunds(300m);
            var blocked = new TransactionEvent.Blocked("FR-42", false);

            Console.WriteLine("=== Оригінали ===");
            Console.WriteLine(success);
            Console.WriteLine(insufficient);
            Console.WriteLine(blocked);

            // Неруйнівна мутація: with створює НОВУ копію зі зміненими полями,
            // а оригінал залишається без змін
            var successCopy = success with { Amount = 200m };
            var insufficientCopy = insufficient with { DeficitAmount = 999m };
            var blockedCopy = blocked with { FraudCode = "CRITICAL", IsAccountSuspended = true };

            Console.WriteLine("\n=== Змінені копії ===");
            Console.WriteLine(successCopy);
            Console.WriteLine(insufficientCopy);
            Console.WriteLine(blockedCopy);

            Console.WriteLine("\n=== Оригінали після копіювання (не змінились) ===");
            Console.WriteLine(success);
            Console.WriteLine(insufficient);
            Console.WriteLine(blocked);
        }
    }
}