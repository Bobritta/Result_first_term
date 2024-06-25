//string[] Array_1 =  new string[] { "Hello", "2", "world", ":-)" };
//string[] Array_1 = new string[] {"1234", "1567", "-2", "computer science"};
string[] Array_1 = new string[] {"Russia", "Denmark", "Kazan"};


// Формирование нового массива из строк, длина которых <= 3 символов
string[] Array_2 = FilterArray(Array_1);

 // Вывод нового массива
Console.WriteLine("Новый массив:");
foreach (string item in Array_2)
    {
        Console.Write(item + " ");
    }

static string[] FilterArray(string[] originalArray)
{
    int count = 0;
    foreach (string item in originalArray)
        {
            if (item.Length <= 3)
            {
                count++;
            }
        }

    string[] newArray = new string[count];
    int index = 0;
    foreach (string item in originalArray)
        {
            if (item.Length <= 3)
            {
                newArray[index] = item;
                index++;
            }
        }

    return newArray;
}
