using System;

namespace Lab4Task3
{
    public static class HrService
    {
        // Передача ЗА ЗНАЧЕННЯМ: метод отримує КОПІЮ структури,
        // тому оригінал у викликаючому коді не змінюється
        public static void GrantRaise(ProbationWorker worker, decimal amount)
        {
            worker.Salary += amount;
            Console.WriteLine($"   [всередині GrantRaise] зарплата копії: {worker.Salary} грн");
        }

        // Передача ЗА ПОСИЛАННЯМ (ref): метод працює з ОРИГІНАЛОМ
        public static void GrantRaiseRef(ref ProbationWorker worker, decimal amount)
        {
            worker.Salary += amount;
            Console.WriteLine($"   [всередині GrantRaiseRef] зарплата оригіналу: {worker.Salary} грн");
        }
    }
}
