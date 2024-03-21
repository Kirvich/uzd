using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();
        string[] originalArray = input.Split(',');

        string[] newArray = FilterArray(originalArray);

        Console.WriteLine("Новый массив с элементами длиной не более 3 символов:");
        foreach (string element in newArray)
        {
            Console.WriteLine(element);
        }
    }

    static string[] FilterArray(string[] array)
    {
        int count = 0;
        // Подсчитываем количество строк, которые удовлетворяют условию
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Trim().Length <= 3) // Добавил метод Trim(), чтобы убрать лишние пробелы в начале и конце строки
            {
                count++;
            }
        }

        string[] filteredArray = new string[count];
        int index = 0;
        // Заполняем новый массив элементами, длина которых не более 3 символов
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Trim().Length <= 3) // Добавил метод Trim(), чтобы убрать лишние пробелы в начале и конце строки
            {
                filteredArray[index] = array[i].Trim(); // Добавил метод Trim() для очистки от лишних пробелов
                index++;
            }
        }

        return filteredArray;
    }
}
