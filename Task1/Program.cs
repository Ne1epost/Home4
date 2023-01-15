// Задача 25 Напишите цикл который принимает 2 числа и возводит в степень

Console.WriteLine("Введите значение A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение B(степень в котору возводим): ");
int numB = Convert.ToInt32(Console.ReadLine());
int result = 1;

for (int i =0; i < numB; i++)
    {
        result = result * numA;
    }
Console.Write(result);



