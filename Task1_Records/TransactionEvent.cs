namespace Lab4Task1
{
    // Базовий абстрактний record з ПРИВАТНИМ конструктором.
    // Тому створити спадкоємця ззовні неможливо: ієрархія "закрита".
    public abstract record TransactionEvent
    {
        private TransactionEvent() { }

        // Підтипи оголошені ВСЕРЕДИНІ базового record, тому вони
        // мають доступ до його приватного конструктора.
        // У дужках записані поля (positional record): компілятор сам
        // створить конструктор, властивості, ToString та Deconstruct.

        // Успішна транзакція
        public sealed record Success(string TransactionId, decimal Amount) : TransactionEvent;

        // Недостатньо коштів
        public sealed record InsufficientFunds(decimal DeficitAmount) : TransactionEvent;

        // Транзакцію заблоковано (підозра на шахрайство)
        public sealed record Blocked(string FraudCode, bool IsAccountSuspended) : TransactionEvent;
    }
}