Console.Write("Enter number -> ");
int num = int.Parse(Console.ReadLine());
Console.Write("Enter number -> ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter \n| 1 - to * \n| 2 to + \n| 3 - to '-' \n| 4 to % -> ");
int result = int.Parse(Console.ReadLine());

if (result == 1)
{
    int r = num * num2;
    Console.WriteLine(r);
}
else if(result == 2)
{
     int r = num + num2;
     Console.WriteLine(r);
}
else if (result == 3)
{
    int r = num - num2;
    Console.WriteLine(r);
}
else if (result == 4)
{
    int r = num % num2;
    Console.WriteLine(r);
}
