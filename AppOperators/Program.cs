// See https://aka.ms/new-console-template for more information
int num1, num2, num3;
Console.WriteLine("Enter three numbers:");

num1= Convert.ToInt32(Console.ReadLine());
num2= Convert.ToInt32(Console.ReadLine());
num3= Convert.ToInt32(Console.ReadLine());
Console.ReadLine();
Console.WriteLine("Multipications of three numbers entered: ");
Console.WriteLine("******************");
Console.WriteLine("Result: " + (num1*num2*num3));
