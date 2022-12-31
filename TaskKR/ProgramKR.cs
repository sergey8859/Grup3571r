//Написать программу, которая из имеющегося массива строк форимрует массив из сторк, 
//длина которых меньше либо равна 3 символам. 
string[] array1 = new string[8] { "massif", "444", "-88", "<=)", "96", "point", "count", "que" };
string[] array2 = new string[array1.Length];
void ArraySorting(string[] array1, string[] array2)
{
    int element = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[element] = array1[i];
            element++;
        }
    }
}
void PrintArray(string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        Console.Write($"{array2[i]} ");
    }
    Console.WriteLine();
}
ArraySorting(array1, array2);
PrintArray(array2);

