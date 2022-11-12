using System;
using System.Globalization;

class Grades
{
    public static void Main(string[] args)
    {
        const float MIDTERM = .25F;
        const float EXAM = .25F;
        const float RESEARCH = .30F;
        const float PRESENTATION = .20F;

        Console.Write("Введите значение для midterm: ");
        int midterm = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Введите значение для exam: ");
        int exam = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Введите значение для research: ");
        int research = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Введите значение для presentation: ");
        int presentation = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        float itog =
              (midterm * MIDTERM) +
              (exam * EXAM) +
              (research * RESEARCH) +
              (presentation * PRESENTATION);
        Console.WriteLine("Оценка за экзамен в семестре: " + midterm);
        Console.WriteLine("Оценка за заключительный экзамен: " + exam);
        Console.WriteLine("Оценка за реферат: " + research);
        Console.WriteLine("Оценка за выступление: " + presentation);
        Console.WriteLine("\n Итоговая оценка: " + itog);
    }
}
