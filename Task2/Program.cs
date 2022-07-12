/* Задача 2: Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}

double res (int a, int b)
{
    double result = Math.Pow((a - b), 2);
    return result;
}

int xa = Prompt ("Введите Xa ");
int xb = Prompt ("Введите Xb ");
int xc = Prompt ("Введите Xc ");
int ya = Prompt ("Введите Ya ");
int yb = Prompt ("Введите Yb ");
int yc = Prompt ("Введите Yc ");



double result = Math.Sqrt(res(xa, ya) + res(xb, yb) + res(xc, yc));
Console. WriteLine("{0:F2}", result);
 