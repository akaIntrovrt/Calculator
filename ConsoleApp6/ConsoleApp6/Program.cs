Console.Write("Введите оценку студента с номером '1' -> ");
int student1 = int.Parse(Console.ReadLine());
Console.Write("Введите оценку студента с номером '2' -> ");
int student2 = int.Parse(Console.ReadLine());
Console.Write("Введите оценку студента с номером '3' -> ");
int student3 = int.Parse(Console.ReadLine());
Console.Write("Введите оценку студента с номером '4' -> ");
int student4 = int.Parse(Console.ReadLine());

int[] students = [student1, student2, student3, student4];

int max = students[0];
int min = students[0];
int counter = 0;
int sum = 0;
double result = 0;
int success = 0;
int failed = 0;

foreach(var item in students)
{
    counter++;
    sum += item;
    result = sum / counter;
    if (item > max)
    {
        max = item;
    }
    if(item < min)
    {
        min = item;
    }
    if(item > 6)
    {
        success++;
    }
    if(item < 6)
    {
        failed++;
    }
}
Console.WriteLine("\n");
Console.WriteLine("Средний балл -> " + result);
Console.WriteLine("Максимальный балл -> " + max);
Console.WriteLine("Минимальный балл -> " + min);
Console.WriteLine("Сдали экзамен -> " + success);
Console.WriteLine("НЕ сдали экзамен -> " + failed);
