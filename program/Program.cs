Console.Clear();
Console.WriteLine("Введите строки через запятую и пробел: ");
string collection = Console.ReadLine()!;
string[] array1 = collection.Split(", ");

Console.WriteLine($"[{String.Join(", ", (array1))}] -> [{String.Join(", ", SortArray(array1))}]");

string[] SortArray(string[] array1)
{
    string sortString = String.Empty;
    foreach (var item in array1)
    {
        if (item.Length <= 3)
        {
            sortString += item + " ";
        }
    }
    string[] sortArray = sortString.TrimEnd().Split(" ");
    return sortArray;

}