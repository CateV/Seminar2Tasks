/*2. Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа.
78 -> 8 
12-> 2 
85 -> 8
*/
int randomNumber = new Random().Next(10, 100);
System.Console.WriteLine($"В случайном числе {randomNumber} ");
int lastDigit = randomNumber % 10;
int firstDigit = randomNumber / 10;
int max = firstDigit;
if (lastDigit > firstDigit)
{
    max = lastDigit;
}
System.Console.WriteLine($"наибольшая цифра - {max}");