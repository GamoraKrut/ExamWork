Console.Clear();

string[] userArray;

Console.WriteLine("Введите массив строк через пробел");
string userString = Console.ReadLine();

userArray = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
var result = new string[userString.Length];
int point = 0;

foreach (var symbols in userArray)
{
    if (symbols.Length <= 3)
    {
        result[point] = symbols;
        point++;
    }
}
Console.Write(string.Join(", ", result, 0, point));
