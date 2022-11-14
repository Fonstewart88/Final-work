// Задача: Написать программу, которая из существующего массива строк формирует массив строк, 
// длина которого меньше или равна 3 символам.  Исходный массив можно ввести с клавиатуры, 
// либо задать в начале выполнения алгоритма.

string[] array1 = new string[9] {"22", "55555", "333", "4444", "A", "BB", "CCC", "DDDD", "1"};

int Array2Length(string[] array)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        count++;
        }
    }
    return count;
}    

int L = Array2Length(array1);

Console.Write(L);