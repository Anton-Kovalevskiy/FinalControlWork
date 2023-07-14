# Итоговая контрольная работа по основному блоку.
## Для выполнения проверочной работы необходимо:
#### 1. Создать репозиторий на **GitHub**.
#### 2. Нарисовать блок-схему алгоритма.
#### 3. Снабдить репозиторий оформленным текстовым описанием решения ( файл *README.md*).
#### 4. Написать программу, решающую поставленную задачу.
#### 5. Использовать контроль версий в работе над этим проектом.

### ***Задача***:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых *меньше, либо равна 3 символам.* Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Процесс выполнения:
- Создание [репозитория][1] на GitHub.
- Создание [блок-схемы](/Рисунок%20блок-схемы%20(метод%20формирования%20искомого%20массива).jpg) алгоритма.
- Написание файла [программы](Program.cs), которая решает поставленную задачу.
- Оформление текстового описания решения (файл *README.md*).
- При выполнении работы был использован контроль версий, а также был добавлен файл *.gitignore*.

### Код программы:

``` c#
int Parameters (string message)                    
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return (result);
}

string [] FillArray (int n)                   
{
    Console.WriteLine($"Введите {n} элементов массива через пробел:");
    string? arrayString = Console.ReadLine();
    string [] array = arrayString.Split(' ');
    return (array);
}

void NewArray (string [] array)         
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
```



[1]: https://github.com/Anton-Kovalevskiy/FinalControlWork