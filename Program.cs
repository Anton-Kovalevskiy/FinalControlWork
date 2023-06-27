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

string [] FillArray (int n)                   // метод заполнения массива и вывод исходного на экран
{
    Console.WriteLine($"Введите {n} элементов массива через пробел:");
    string? arrayString = Console.ReadLine();
    string [] array = arrayString.Split(' ');
    return (array);
}


