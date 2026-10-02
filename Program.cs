using System.Runtime.InteropServices;

int lessonNumber = 5;
int totalLessons = 1;
while (lessonNumber  >= totalLessons)
{
    Console.WriteLine($"пара{lessonNumber}");
    lessonNumber--;
}
Console.WriteLine("пара закончилась");


Console.WriteLine("ВВодите оценки по одной, для завершения введите -1:");
int grade = int.Parse(Console.ReadLine());
int count = 0;
while (grade != -1)
{
    count++;
    Console.WriteLine($"Оценка принята: {grade}");
    grade = int.Parse(Console.ReadLine());
}
Console.WriteLine($"счет оценок{count}");
Console.WriteLine("Ввод завершен");

int summ = 0;
int countt = 0;

Console.WriteLine("Вводите оценки по одной, для завершения введите -1:");
int gradee = int.Parse(Console.ReadLine());

while (gradee != -1)
{
    summ += gradee;
    countt++;
    gradee = int.Parse(Console.ReadLine());
}
if (count > 0)
{
    Console.WriteLine($"Средний балл: {(double)summ / count}");
}
else
{
    Console.WriteLine("Оценок не было введено");
}