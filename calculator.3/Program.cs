
Console.Write("enter first number:");
double num1 =double.Parse(Console.ReadLine());

Console.Write("enter sybol:");
char symbol = char.Parse(Console.ReadLine());

Console.Write("enter second number:");
double num2 = double.Parse(Console.ReadLine());

if (symbol == '+')
{
    Console.WriteLine(num1 + num2);
}

if (symbol == '-')
{
    Console.WriteLine(num1 - num2); 
}

if (symbol == '*')
{
    Console.WriteLine(num1 * num2); 
}

if (symbol == '/')
{  
    if (num2 == 0)

        Console.WriteLine("eded 0 A bolune bilmez");

    Console.WriteLine(num1 / num2);      
}


















