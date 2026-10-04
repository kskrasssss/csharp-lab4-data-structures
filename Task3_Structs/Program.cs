using System;

namespace Lab4Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Комбінація прапорців через оператор |
            var worker = new ProbationWorker("Іваненко І.І.", 20000m, 60,
                AccessLevels.Office | AccessLevels.Lab);

            Console.WriteLine("Початковий стан:");
            Console.WriteLine(worker);
            Console.WriteLine("Має доступ до Lab? " + worker.Access.HasFlag(AccessLevels.Lab));
            Console.WriteLine("Має доступ до Vault? " + worker.Access.HasFlag(AccessLevels.Vault));

            // 1. Передача за значенням: оригінал НЕ змінюється
            Console.WriteLine("\n--- GrantRaise (за значенням) ---");
            HrService.GrantRaise(worker, 5000m);
            Console.WriteLine("Після виклику, оригінал: " + worker.Salary + " грн (не змінився)");

            // 2. Передача за посиланням: оригінал змінюється
            Console.WriteLine("\n--- GrantRaiseRef (ref) ---");
            HrService.GrantRaiseRef(ref worker, 5000m);
            Console.WriteLine("Після виклику, оригінал: " + worker.Salary + " грн (змінився)");

            // 3. readonly struct
            Console.WriteLine("\n--- TenuredEmployee (readonly struct) ---");
            var tenured = new TenuredEmployee("Петренко П.П.", 40000m, 8,
                AccessLevels.Office | AccessLevels.ServerRoom | AccessLevels.Vault);
            Console.WriteLine(tenured);

            // Розкоментуй рядок нижче, і компілятор покаже помилку CS0200:
            // tenured.Salary = 50000m;

            // Єдиний спосіб "змінити": створити нову структуру
            TenuredEmployee raised = tenured.WithRaise(10000m);
            Console.WriteLine("Нова копія: " + raised);
            Console.WriteLine("Оригінал:   " + tenured);
        }
    }
}