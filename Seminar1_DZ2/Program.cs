Console.WriteLine("Привет, введи 2 числа!");

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int max = A;
if(A > max) max = A;
if(B > max) max = B;
int min = A;
if(A < min) min = A;
if(B < min) min = B;
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);