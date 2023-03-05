# **Exam Work Solution**
- Создаем *массив* в который будут записаны символы введеные юзером

```csharp
string[] userArray;
```

- Конвертитруем введеный юзером текст в *строку*, чтобы разбить на "части"

```csharp
Console.WriteLine("Введите массив строк через пробел");
string userString = Console.ReadLine();
```

- Разбиваем на "части" введеную *строку*, убираем лишние пробелы, если они будут, и создаем пустой *массив*, в который будем добавлять наборы символов

```csharp
userArray = userString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
var result = new string[userString.Length];
```

- Создаем переменную, равную "0", она будет обозначать позицию в итоговом массиве

```csharp
int point = 0;
```

- Используя функцию *Foreach* "перебираем" массив, и с помощью функции "if" находим наборы символов длинной не более 3-х, и подставляем в массив

```csharp
foreach (var symbols in userArray)
{
    if (symbols.Length <= 3)
    {
        result[point] = symbols;
        point++;
    }
}
```
- Выводим результат

```csharp
Console.Write(string.Join(", ", result, 0, point));
```