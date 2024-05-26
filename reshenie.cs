using System;

class Program
{
    static void Main()
    {
        // Вводим массив строк с клавиатуры или задаем его в коде
        Console.WriteLine("Введите строки через пробел:");
        string input = Console.ReadLine();
        string[] initialArray = input.Split(' ');

        // Определяем размер нового массива
        int count = 0;
        foreach (string str in initialArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив и заполняем его подходящими строками
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

        // Выводим новый массив
        Console.WriteLine("Новый массив строк, длина которых меньше либо равна 3 символам:");
        foreach (string str in newArray)
        {
            Console.WriteLine(str);
        }
    }
}