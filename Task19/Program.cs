// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности 
// и проверяет, является ли оно палиндромом. Через строку нельзя решать само собо


Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
char[] numbers = num.ToString().ToArray();
int x = numbers.Length - 1;
int count = 0;

for (int i = 0; i < (numbers.Length / 2); i++)
{
    if (numbers[i] == numbers[x - i])
    {
        count++;
    }
}

for (int j = 0; j < (numbers.Length); j++)
{
    Console.Write($"{numbers[j]}");
}

if (count == (numbers.Length / 2)) Console.WriteLine(" является палиндромом");
else
{
    Console.WriteLine(" не являетсяя палиндромом");
}
