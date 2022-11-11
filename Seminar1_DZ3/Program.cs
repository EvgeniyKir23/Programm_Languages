Console.WriteLine("Привет, введи число!");
int A = Convert.ToInt32(Console.ReadLine());
if(A % 2 == 0) 
{
    Console.Write(A + " -> Да");
}
else
{
    Console.Write(A + " -> Нет");
}