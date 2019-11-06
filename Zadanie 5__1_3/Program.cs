using System;
/*Написать метод, входными параметрами которого являются строка,
символ, номер символа в строке. Метод должен заполнять строку,
начиная с указанного номера, заданными символами, до конца
строки.*/

class Zadanie_5_1_3
{

    static void Main(string[] args)
    {
        string str1;
        str1 = SomeFunc("Неважно кокой-то текст", '№', 5);
        Console.WriteLine(str1);
    }
    static string SomeFunc(string str, char z, int n)
    {
        char[] mass = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
            mass[i] = (char)str[i];

        for (int i = n - 1; i < str.Length; i++)
            mass[i] = z;

        string str1 = new string(mass);
        return str1;
    }

}