// Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых либо меньше либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] arrayFirst = new string[7] {"2", ";-)", "hello", "world", "yes", "2009", "11"};
string[] arraySecond = new string[arrayFirst.Length];
void ArraySecond(string [] arrayFirst, string [] arraySecond)
{
    int count = 0;
    for (int i=0; i<arrayFirst.Length; i++)
    {
        if(arrayFirst[i].Length <= 3)
        {
        arraySecond[count] = arrayFirst[i];
        count++;
        }
    }
}
ArraySecond(arrayFirst, arraySecond);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(arraySecond);