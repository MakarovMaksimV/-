/* Задача: Написать программу, которая из имеющегося массива строк формирует
новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/

Console.Write("Введите размер массива: ");
string input = Console.ReadLine()!;
int size = GetArrayIndex(input);


int GetArrayIndex(string input)
{
    int size = 0;
    try
    {
        size = Convert.ToInt32(input);

        if (size < 1)
        {
            Console.WriteLine("Размер массива должен быть не меньше 1");
            return 0;
        }


        string[] array = new string[size];

        ArrayFromUser(size);
        Console.WriteLine();
        Console.WriteLine($"Заданный массив состоящий из {size} элементов: ");
        Print(array);
        Console.WriteLine();
        Console.WriteLine();
        ResultArray(array);


        string[] ArrayFromUser(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                array[i] = Console.ReadLine()!;
            }
            return array;
        }


        void Print(string[] array)
        {
            foreach (string el in array)
            {
                Console.Write(el + "\t");
            }

        }


        void ResultArray(string[] array)
        {
            int size = 0;
            foreach (string el in array)
            {
                if (el.Length <= 3)
                {
                    ++size;
                }
            }

            if (size > 0)
            {
                Console.WriteLine($"Результат: массив из {size} элемента(-ов), содержащих 3 или менее символов");
                foreach (string el in array)
                {
                    if (el.Length <= 3)
                    {
                        Console.Write($"{el} \t");
                    }
                }
            }
            else
            {
                Console.WriteLine("В заданном массиве отсутствуют элементы соответствующие условию");
            }
        }
    }


    catch
    {
        Console.WriteLine("Ошибка! Не задан размер массива!");
    }
    return size;
}