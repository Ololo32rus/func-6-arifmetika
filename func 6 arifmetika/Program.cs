//1. 2х значное число. получить сумму при перестановке цифр
/*
Console.WriteLine ($"Введите число от 10 до 99 = ");
int a = int.Parse(Console.ReadLine());
if (a>9 && a<100)
{
int b = a/10;
int c = a%10;
int d = b + c;
    Console.WriteLine($"Сумма при перестановке цифр = {d}");
}
else
{
    Console.WriteLine($"Введите число в диапазоне 10 - 99");
}
*/

int a;
//bool num = true;

void Input ()
{
    Console.WriteLine($"Введите число от 10 до 99 = ");
   int a = int.Parse(Console.ReadLine());
}
int A(int a)
{
    if (a > 9 && a < 100)
    {
        int b = a / 10;
        int c = a % 10;
        int d = b + c;

        Console.WriteLine($"Сумма при перестановке цифр = {d}");
    }

    else if (a<9 && a>99)
    {
            Console.WriteLine($"Введите число в диапазоне 10 - 99");
    }
    return a;
}

/*
void Output(string msg)
{ 
Console.WriteLine(msg);
}
try
{
    Input();
    do
    {
        A(a);
        num = false;
    } while (num);
}
catch
{
    Output("ASdQWEASDAC");
}
*/