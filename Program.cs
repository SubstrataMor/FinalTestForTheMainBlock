string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan"};
void ResultArray(string[] array)
{
    var resultArr = new string[array.Length];
    var element = 0;
    foreach (var value in array)
    {
        if (value.Length <= 3)
        {
            resultArr[element] = value;
            element++;
        }
    }
    PrintArray(resultArr);
}
void PrintArray(string[] array)
{
    Console.Write("[");
    foreach (var item in array )
    {
        if (item != null)
            Console.Write($"{item},");
    }
    Console.Write("]");
    Console.WriteLine();
}
ResultArray(arr1);
ResultArray(arr2);
ResultArray(arr3);