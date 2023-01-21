/*Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деление.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int firstNumber = InputStringToInt("введите первое число");
int secondNumber = InputStringToInt("введите второе число");
if (secondNumber%firstNumber==0)
{
    System.Console.WriteLine($"Число {secondNumber} кратно числу {firstNumber}");
}
else 
{
    System.Console.WriteLine($"Число {secondNumber} не кратно числу {firstNumber}, остаток равен {secondNumber%firstNumber}");
}