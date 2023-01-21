/*4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14 -> нет 
46 -> нет 
161 -> да
*/
/* int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int number = InputStringToInt("введите число");
if (number % 7 == 0)
{
    if (number % 23 == 0)
        Console.WriteLine($"Число {number} одновременно кратно и 7 и 23");
    else
        Console.WriteLine($"Число {number} не кратно хотя бы одному из чисел 7 и 23");
}
else
        Console.WriteLine($"Число {number} не кратно хотя бы одному из чисел 7 и 23");

*/
/*ЧТО В ЭТОМ КОДЕ НЕ ТАК???

???????
*/
int InputStringToInt(string message)
{
    Console.WriteLine(message);
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
int a = InputStringToInt("введите число");
bool MultipleToNumber(int multiple)
{
        if (a%multiple == 0)
    return true;
    else
    return false;
}
bool b = MultipleToNumber(7);
bool c = MultipleToNumber(23);
if (b == true && c == true)
{
    System.Console.WriteLine("да");
}
else 
{
        System.Console.WriteLine("не кратно хотя бы одному: 7 или 23");

}