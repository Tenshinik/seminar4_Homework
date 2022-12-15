/*  Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] )
 и выводит на экран десятичное представление числа, записанного в СС по основанию 15
N: 3 [9, 4, 12] => 2097
*/

Console.WriteLine("Задан массив из N элементов");
string ? input = Console.ReadLine();
var result = input.Split(','); 
List<int> int_result = new();

for(int i = result.Length - 1; i >= 0; i--)
{
   int_result.Add(Convert.ToInt32(result[i]));
}

int base_num = 15;
int kom = 0;
for(int i = 0; i < int_result.Count; i++)
{
    kom += (int)Math.Pow(base_num, i) * int_result[i];
}
Console.WriteLine(kom);