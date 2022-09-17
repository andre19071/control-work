// Задача: Написать программу, которая из массива массива строк формирует массив из строк,
// длина либо включает либо меньше либо равно 3 символа. Первоначальный массив можно ввести 
// с клавиатуры,либо нажать на начало выполнения алгоритма.
// Не рекомендуется использовать коллекции, лучше всего собирать уникальные массивы.
// Примеры:
// ["Привет", "2", "мир", ":-)"] → ["2", ":-)"]
// ["1234", "1567", "-2", "информатика"] → ["-2"]
// ["Россия", "Дания", "Казань"] → [] 

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Количество элементов в массиве ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    string symbol = Console.ReadLine()!;
    arrayStrings[i] = symbol;
}

string[] arrayFinal = new string[size];
int length = 3;
int count = 0;

for (int i = 0; i < size; i++)
{
    if (arrayStrings[i].Length <= length)
    {
        arrayFinal[count] = arrayStrings[i];
        count++;
    }
}

Console.WriteLine();
PrintArray(arrayFinal);