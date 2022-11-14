// Задача: Написать программу, которая из существующего массива строк формирует массив строк, 
// длина которого меньше или равна 3 символам.  Исходный массив можно ввести с клавиатуры, 
// либо задать в начале выполнения алгоритма.

int Array2Length(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        count++;
        }
    }
    return count;
}    

void FillArray(string[] arrayX, string[] arrayY)
{
    int count = 0;
    for (int i = 0; i < arrayX.Length; i++)
    {
    if(arrayX[i].Length <= 3)
        {
        arrayY[count] = arrayX[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] array1 = new string[9] {"22", "55555", "333", "4444", "A", "BB", "CCC", "DDDD", "1"};
int L = Array2Length(array1);
string[] array2 = new string[L];
FillArray(array1,array2);
PrintArray(array2);

