/*  Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */ 


int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}

int number = Prompt ("Введите число ");
int oldNumber = number;
int result = 0;


while (number > 0)
{
    result = number % 10 + result * 10;
    number = number / 10;
}


if (oldNumber == result)
{
    Console.WriteLine ("Число является палиндромом");
}  else Console.WriteLine ("Число не палиндром");
