// Принимает на вход число и выдает сумму цифр в числе

Console.Write("Введите число: ");
string value = Console.ReadLine();
int sum = 0;

for (int i =0; i < value.Length; i++)
{
    int number = int.Parse(Convert.ToString(value[i]));
    sum += number;
}
Console.Write(sum);