// Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдает максимальное из этих чисел

Console.WriteLine("введите число");
int score01 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int score02 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Введите число 3");
int score03 = Convert.ToInt32(Console.ReadLine());

if (score01> score02)
    if (score01 > score03)   
Console. WriteLine(score01 + " Максимальное число");
else 
Console.WriteLine(score03 + " Максимальное число");

{
    if (score01 < score02)
        if (score02 > score03)
    Console.WriteLine(  score02 + " Максимальное число");
    else
    Console.WriteLine(score03 + " Максимальное число");
}