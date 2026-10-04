<div align="center">

# Лабораторна робота №4

### Сучасні структури даних та контроль потоку

![C#](https://img.shields.io/badge/C%23-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dotnet&logoColor=white)
![Git](https://img.shields.io/badge/Git-F05032?style=for-the-badge&logo=git&logoColor=white)

</div>

---

## Про проєкт

Репозиторій містить виконану лабораторну роботу з дисципліни **«<Назва дисципліни>»**.

**Мета роботи:** практичне освоєння сучасних парадигм управління даними (Data-Oriented Programming): незмінних носіїв інформації, закритих ієрархій та конструкцій зіставлення із шаблонами для гарантування безпеки типів і оптимізації пам'яті на етапі компіляції.

## Структура репозиторію

```
csharp-lab4-data-structures/
├── Task1_Records/         # Records та закриті ієрархії
├── Task2_Switch/          # Switch Expressions та Pattern Matching
├── Task3_Structs/         # Enums, struct та readonly struct
├── Task4_DateTime/        # Вбудовані структури дати і часу
├── csharp-lab4-data-structures.slnx
└── README.md
```


## Завдання

### Завдання 1. Records та закрита ієрархія
Предметна область: **E-commerce**. Абстрактний `record TransactionEvent` із приватним конструктором і три підтипи: `Success`, `InsufficientFunds`, `Blocked`. Показано неруйнівну мутацію через оператор `with`.

### Завдання 2. Switch Expressions та Pattern Matching
Метод `TransactionRouter.Route` маршрутизує подію виключно через `switch`-вираз, без гілки `_ =>`. Використано positional та property patterns, а також логічні `and`. Для `Blocked` з кодом `CRITICAL` повертається команда «Миттєво сповістити службу безпеки».

### Завдання 3. Enum та структури
Предметна область: **кадри**.

| Елемент | Призначення |
|---|---|
| `AccessLevels` | `[Flags]` enum: Office, ServerRoom, Vault, Lab |
| `ProbationWorker` | Мутабельна `struct` |
| `TenuredEmployee` | Незмінна `readonly struct` |
| `GrantRaise` | Передача за значенням: оригінал не змінюється |
| `GrantRaiseRef` | Передача через `ref`: оригінал змінюється |

### Завдання 4. Дата і час
Програма за введеною датою і часом історичної події визначає, на якій хвилині від початку року вона відбулася та який це був день тижня. Використано вбудовані структури `DateTime` і `TimeSpan`.


## Запуск

**Вимоги:** встановлений [.NET SDK](https://dotnet.microsoft.com/download).

```bash
git clone https://github.com/kskrasssss/csharp-lab4-data-structures.git
cd csharp-lab4-data-structures

dotnet run --project Task1_Records
dotnet run --project Task2_Switch
dotnet run --project Task3_Structs
dotnet run --project Task4_DateTime
```

## Автор

**Краснікова Катерина Євгенівна**
Студентка 2 курсу, 243А-1 група
Чернівецький національний університет імені Юрія Федьковича, 2026 рік

---

<div align="center">
<sub>Лабораторна робота виконана в навчальних цілях</sub>
</div>
