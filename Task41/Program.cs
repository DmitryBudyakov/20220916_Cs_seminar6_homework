// Задача 41:
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

int[] NumbersByUser(int quantity)   // массив с числами, введенными пользователем
{
    int[] array = new int[quantity];

    for (int i = 0; i < quantity; i++)
    {
        Console.Write($"Введите число {i + 1} из {quantity}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int CountPosInArray(int[] array)    // считает кол-во положительных элементов массива
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    return count;
}

string PrintArrayAsString(int[] array)  // возвращает строку с элементами массива
{
    int length = array.Length;
    string output = String.Empty;

    for (int i = 0; i < length; i++)
    {
        if (i == length - 1) output += array[i];
        else output += $"{array[i]}, ";
    }
    
    return output;
}

Console.Clear();
// Ввод пользователя
Console.Write("Определите кол-во чисел, которое будет введено: ");
int numbers = Convert.ToInt32(Console.ReadLine());

if (!(numbers > 0)) Console.WriteLine("Ошибка ввода. Количество чисел должно быть > 0.");
else
{
    // фиксация введеных чисел
    int[] enteredNumbers = NumbersByUser(numbers);
    string enteredNumbersOut = PrintArrayAsString(enteredNumbers);

    // определение кол-ва положительных
    int posNumbers = CountPosInArray(enteredNumbers);

    // вывод результата
    Console.WriteLine($"Количество положительных среди введенных чисел {enteredNumbersOut} -> {posNumbers}");
}
