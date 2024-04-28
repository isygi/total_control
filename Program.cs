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
