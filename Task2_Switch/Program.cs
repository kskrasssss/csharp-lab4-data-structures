using System;
using Lab4Task1;

namespace Lab4Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Масив базового типу з різними підтипами та різними значеннями полів,
            // щоб перевірити всі гілки
            TransactionEvent[] events =
            {
                new TransactionEvent.Success("TX-1", 500m),
                new TransactionEvent.Success("TX-2", 5000m),
                new TransactionEvent.Success("TX-3", 25000m),

                new TransactionEvent.InsufficientFunds(7500m),
                new TransactionEvent.InsufficientFunds(1200m),
                new TransactionEvent.InsufficientFunds(0m),

                new TransactionEvent.Blocked("CRITICAL", true),
                new TransactionEvent.Blocked("FR-17", true),
                new TransactionEvent.Blocked("LIMIT", false)
            };

            foreach (TransactionEvent e in events)
            {
                Console.WriteLine(e);
                Console.WriteLine("   -> " + TransactionRouter.Route(e));
                Console.WriteLine();
            }
        }
    }
}
