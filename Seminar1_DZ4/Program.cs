// See https://aka.ms/new-console-template for more information

Console.WriteLine("Привет, введи 3 числа!");

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());
int max = A;
if(A > max) max = A;
if(B > max) max = B;
if(C > max) max = C;
Console.Write("max = ");
Console.WriteLine(max);