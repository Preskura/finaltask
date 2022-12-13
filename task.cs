// Написать программу, которая из имеющегося массива формирует массив из строк,
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении пользоваться массивами.
// string[] array = new string[] {"1234", "64849", "32", "adfjk", "adv", "v", "l", "a", "d"};

Console.Write("Введите кол-во элеметов: ");
int input = Convert.ToInt32(Console.ReadLine());
string[] array = new string[input];

for (int i = 0; i < input; i++)
{
    Console.Write($"Введите {i + 1}-ый элемент массива= ");
    array[i] = Console.ReadLine();
}
Console.WriteLine();

Console.Write("Числа массива в которых число символов меньше или равно трем: ");

for (int i = 0; i < array.Length; i++)
{
    int n = array[i].Length;
    if (n <= 3)
    {
        Console.Write(" | " + array[i]);
    }
}


// foreach (string str in array)
// {
//     int lenght = 0;
//     foreach (char symbol in str)
//     {
//         lenght++;
//     }
//     if (lenght <= 3)
//     {
//         Console.Write($" | {str}");
//     }
// }


// var selected = array.Select(x => x.Length <= 3 ? x : "");
// foreach (var item in selected)
// {
//     if (!string.IsNullOrEmpty(item))
//         Console.Write($" | {item}");
// }