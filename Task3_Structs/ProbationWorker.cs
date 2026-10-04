namespace Lab4Task3
{
    // Звичайна (мутабельна) структура: поля можна змінювати
    public struct ProbationWorker
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int ProbationDays { get; set; }   // скільки днів лишилось випробувального терміну
        public AccessLevels Access { get; set; }

        public ProbationWorker(string name, decimal salary, int probationDays, AccessLevels access)
        {
            Name = name;
            Salary = salary;
            ProbationDays = probationDays;
            Access = access;
        }

        public override string ToString()
        {
            return $"{Name}, зарплата: {Salary} грн, випробувальний термін: {ProbationDays} дн., доступ: {Access}";
        }
    }
}