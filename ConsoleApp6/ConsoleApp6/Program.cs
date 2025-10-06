Console.Write("Введите оценку студента с номером '1' -> ");
int student1 = int.Parse(Console.ReadLine());
Console.Write("Введите оценку студента с номером '2' -> ");
int student2 = int.Parse(Console.ReadLine());
Console.Write("Введите оценку студента с номером '3' -> ");
int student3 = int.Parse(Console.ReadLine());
Console.Write("Введите оценку студента с номером '4' -> ");
int student4 = int.Parse(Console.ReadLine());

int[] students = [student1, student2, student3, student4];

int[] chetnie = [students.Length];

int max = students[0];
int min = students[0];
int counter = 0;
int sum = 0;
double result = 0;

for (int i = 0; i < students.Length; i++)
{
    counter++;
    Console.Write(students[i] + " | ");
}

void Sum()
{
    foreach (var item in students)
    {
        sum += item;
    }
    Console.WriteLine("\nСумма оценок -> " + sum);
}
void Max()
{
    foreach (var item in students)
    {
        if (item > max)
        {
            max = item;
        }
        if (item < min)
        {
            min = item;
        }
    }
    Console.WriteLine("Максимальная оценка -> " + max);
    Console.WriteLine("Минимальная оценка -> " + min);
}
void Midle()
{
    foreach (var item in students)
    {
        result = sum / counter;
    }
    Console.WriteLine("Средняя оценка -> " + result);

}
void Chetnie()
{
    foreach (var item in students)
    {
        if (item % 2 == 0)
        {
            Console.Write(item + " | ");
        }
    }
}
Sum();
Max();
Midle();
Chetnie();


//foreach(var item in students)
//{
//    counter++;
//    sum += item;
//    result = sum / counter;
//    if (item > max)
//    {
//        max = item;
//    }
//    if(item < min)
//    {
//        min = item;
//    }
//    if(item > 6)
//    {
//        success++;
//    }
//    if(item < 6)
//    {
//        failed++;
//    }
//}
//Console.WriteLine("\n");
//Console.WriteLine("Средний балл -> " + result);
//Console.WriteLine("Максимальный балл -> " + max);
//Console.WriteLine("Минимальный балл -> " + min);
//Console.WriteLine("Сдали экзамен -> " + success);
//Console.WriteLine("НЕ сдали экзамен -> " + failed);