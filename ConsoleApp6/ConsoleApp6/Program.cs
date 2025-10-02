Console.Write("Enter number -> ");
int num = int.Parse(Console.ReadLine());
Console.Write("Enter number -> ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Enter 1 - to *, 2 to +, 3 - to '-' -> ");
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

