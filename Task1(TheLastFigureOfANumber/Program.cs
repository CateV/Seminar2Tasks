/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8 */

int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}

int number = InputStringToInt("введите 3-значное число");
if (number < 99 || number > 999)
{
    System.Console.WriteLine("число не трёхзначное");
}
else
{
    int theThirdFigure = number % 10;
    System.Console.WriteLine(theThirdFigure);
}