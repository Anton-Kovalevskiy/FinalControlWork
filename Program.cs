/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
*/

int Parameters (string message)                        // метод задания размера массива
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return (result);
}

string [] FillArray (int n)                   // метод заполнения массива 
{
    Console.WriteLine($"Введите {n} элементов массива через пробел:");
    string? arrayString = Console.ReadLine();
    string [] array = arrayString.Split(' ');
    return (array);
}

void NewArray (string [] array)          // метод формирования нового массива и вывод его на экран
{
    string [] newArray = new string [array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i].Length <= 3)
        {
            newArray [count] = array [i];
            count ++; 
        } 
    }
    Console.Write("Получен массив: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"[{newArray[i]}]");
    }
}

string mes = "Введите количество элементов массива -> ";
int n = Parameters(mes);
string [] array = FillArray (n);
Console.WriteLine("Исходный массив: [" + String.Join("] [", array) + "]");
NewArray(array);