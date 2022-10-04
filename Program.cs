//Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше или равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
//либо задать на старте выполнения алгоритма. 

//["hello", "2", "world", ":-)"] -> ["2",":-)"]
//["Russia", "Denmark", "Kazan"] -> []

string[]array1 = new string[7] {"hello", "2", "world", ":-)", "88", "yes", "geek"};
string[]array2 = new string[array1.Length];

void SecondArray (string[]array1, string[]array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

void PrintArray (string[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} " );
    }
    Console.WriteLine("]");
}

SecondArray(array1, array2);
PrintArray(array2);

