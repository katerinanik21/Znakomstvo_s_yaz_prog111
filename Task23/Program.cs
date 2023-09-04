// Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//5 ->
//1 | 1
//2 | 8
//3 | 27
//4 | 64
//5 | 125
Console.Write("Введите число N: ");
string number = Console.ReadLine();
Console.WriteLine();

bool LetterInNumbers(string let)
{
    int n = let.Length;
    bool yes = true;
    
        for (int i = 0; i < n; i++)
        {
            // if (Char.IsLetter(let[i]) == true || Char.IsSymbol(let[i]) == true)
            if (Char.IsDigit(let[i]) == false)
            {
                yes = false;
                return yes;
            }
        }
        return yes;
}

void TableCubeNumbers(int num)
{
    Console.WriteLine("Число\tКуб числа");
    
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine("{0}\t{1}", i, Math.Pow(i, 3));
    }
}

void Break()
{
    Console.WriteLine("{0} -> Некорректный ввод!\nВедите цисло от 1 или равное 1", number);
}

bool letter = LetterInNumbers(number);
int numbers;
if (letter == true)
{
    numbers = Convert.ToInt32(number);
    if (numbers > 0)
    {
        Console.WriteLine($"Таблица кубов чисел от 1 до {number}.");
        Console.WriteLine();
        TableCubeNumbers(numbers);
    }
    else Break();
}
else Break();
