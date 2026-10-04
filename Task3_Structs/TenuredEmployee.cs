namespace Lab4Task3
{
    // readonly struct: компілятор забороняє змінювати будь-які поля після створення
    public readonly struct TenuredEmployee
    {
        // Тільки get (без set): значення задаються лише в конструкторі
        public string Name { get; }
        public decimal Salary { get; }
        public int YearsWorked { get; }
        public AccessLevels Access { get; }

        public TenuredEmployee(string name, decimal salary, int yearsWorked, AccessLevels access)
        {
            Name = name;
            Salary = salary;
            YearsWorked = yearsWorked;
            Access = access;
        }

        // Змінити не можна, тому повертаємо НОВУ структуру з новою зарплатою
        public TenuredEmployee WithRaise(decimal amount)
        {
            return new TenuredEmployee(Name, Salary + amount, YearsWorked, Access);
        }

        public override string ToString()
        {
            return $"{Name}, зарплата: {Salary} грн, стаж: {YearsWorked} р., доступ: {Access}";
        }
    }
}
