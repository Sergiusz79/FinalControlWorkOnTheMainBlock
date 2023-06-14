/* Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
*/

int EnterLengthOfArray()
{
    int n;
    Console.WriteLine("Please enter the number of array elements: ");
    while (!int.TryParse(Console.ReadLine(), out n))
    {Console.WriteLine("It's not number! Please enter number!");}
    return n;
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Please enter the data of the {(i + 1)} element: ");
        array[i] = Console.ReadLine()!;
    }
    Console.WriteLine();
    return;
}

int Count(string[] array)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) j++;
    }
    return j;
}

void FillNewArray(string[] array, string[] newarray)
{
    int a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[a] = array[i];
            a++;
        }
    }
}

void Task()
{
    int n = EnterLengthOfArray();

    string[] array = new string[n];
    FillArray(array);

    int j = Count(array);
    string[] newarray = new string[j];
    FillNewArray(array, newarray);

    Console.WriteLine
    ($"{j} array elements whose length <=3: {string.Join(", ", newarray)}");
}

Task();

