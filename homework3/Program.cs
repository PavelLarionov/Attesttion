﻿// Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArrayReverse(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write($"{array[index]} ");
    PrintArrayReverse(array, index - 1);
}

    int[] array = { 1, 2, 3, 4, 5 };
    PrintArrayReverse(array, array.Length - 1);

