
Console.WriteLine("Привет, введи 2 числа!");

int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int max = A;
if(A > max) max = A;
if(B > max) max = B;
Console.Write("max = ");
Console.WriteLine(max);