using System;

class ArrayExample
{
    /// <summary>
    /// Точка входа в приложение. Демонстрирует перебор символов строки и вывод каждого символа на отдельной строке.
    /// </summary>
    /// <param name="args">Аргументы командной строки (не используются).</param>
    static void Main()
    {
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        string name = "";
        int[] a = new int[10];
        for (int i = 0; i < letters.Length; i++)
        {
            name += letters[i];
            a[i] = i + 1;
            SendMessage(name, a[i]);
        }
        Console.ReadKey();
    }

    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}