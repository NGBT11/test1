using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строки через пробел:");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(' ');

        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        string[] newArray = new string[count];
        int index = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                newArray[index] = str;
                index++;
            }
        }

        Console.WriteLine("Новый массив строк, длина которых меньше либо равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}
