using System;

class Program
{
    static void Main()
    {
        
        string[] initialArray = { "hello", "2", "world", ":-)" };
        int count = 0;
        foreach (var str in initialArray)
        {
            if (str.Length <= 3) count++;
        }

     string[] newArray = new string[count];
        int index = 0;

foreach (var str in initialArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }
        
        Console.WriteLine("Новый массив строк, длина которых меньше или равна 3 символам:");
        foreach (var str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}