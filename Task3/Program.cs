/* Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27. 
5 -> 1, 8, 27, 64, 125 */

int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}


int a = Prompt ("Введите число ");

for (int i = 1; i <= a; i++)
{
    int result = i * i * i;
    if(i == a) // чтобы не было в конце ","
    {
        Console.Write ($"{result}");
        break;
    }
    Console.Write ($"{result}, ");
}