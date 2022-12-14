/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
Строки использовать нельззя
*/

Console.WriteLine("Enter number");
int h = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (h > 0)
{
int num = h % 10;
h = h / 10;
sum = sum + num;
}
Console.WriteLine("the sum of all the digits in the number is: " + sum);
