using Lab4Task1;

namespace Lab4Task2
{
    public static class TransactionRouter
    {
        // Компілятор C# поки не вміє розпізнавати "закриту" ієрархію з приватним
        // конструктором, тому може показати попередження CS8509 про вичерпність.
        // Ми свідомо вимикаємо його: гілки _ => за умовою лаби використовувати не можна.
#pragma warning disable CS8509
        public static string Route(TransactionEvent e) => e switch
        {
            // ----- Success -----
            // Property pattern: перевірка властивості без приведення типу
            TransactionEvent.Success { Amount: > 10000m }
                => "Велика сума: відправити на ручну перевірку",

            // Positional pattern: розпаковуємо record на змінні (id) і перевіряємо суму
            TransactionEvent.Success(var id, > 1000m)
                => $"Транзакція {id}: підвищений контроль",

            // Усі решта успішних транзакцій
            TransactionEvent.Success(var id, var amount)
                => $"Транзакція {id} на {amount} грн: проводимо у звичайному режимі",

            // ----- InsufficientFunds -----
            TransactionEvent.InsufficientFunds { DeficitAmount: > 5000m }
                => "Великий дефіцит: запропонувати кредитний ліміт",

            TransactionEvent.InsufficientFunds { DeficitAmount: > 0m and <= 5000m }
                => "Невеликий дефіцит: запропонувати поповнити рахунок",

            // Решта значень (наприклад, 0 або від'ємні): це помилка даних
            TransactionEvent.InsufficientFunds(var deficit)
                => $"Некоректний дефіцит ({deficit}): перевірити дані",

            // ----- Blocked -----
            // Обов'язкова умова варіанта
            TransactionEvent.Blocked { FraudCode: "CRITICAL" }
                => "Миттєво сповістити службу безпеки",

            TransactionEvent.Blocked { IsAccountSuspended: true }
                => "Акаунт призупинено: передати в службу підтримки",

            // Тут розпаковуємо і код, і прапорець (false)
            TransactionEvent.Blocked(var code, false)
                => $"Тимчасове блокування за кодом {code}: надіслати SMS клієнту"
        };
#pragma warning restore CS8509
    }
}