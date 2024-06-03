string[] StrArray1 = new string[5] {"Hello", "2", "world", ":-|", "Hi"};
string[] StrArray2 = new string[StrArray1.Length];
void CreateNewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
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
CreateNewArray(StrArray1, StrArray2);
PrintArray(StrArray2);
