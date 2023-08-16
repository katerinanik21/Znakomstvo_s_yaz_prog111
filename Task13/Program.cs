// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введите число: "); // Ввод значения пользователем
string number = Console.ReadLine();

char[] numberArray = number.ToCharArray();
if (numberArray.Length >= 3)
{
    Console.Write($"{number} -> {numberArray[2]}");
}
else
{
    Console.Write($"{number} -> третьей цифры нет");
}
