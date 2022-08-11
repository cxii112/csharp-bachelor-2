# Массивы 2 (СРС)

## Работа с файлами
Думаю может смутить вот это:

```csharp
string inputPath = $@"{args[0]}";
string outputPath = $@"{args[1]}out.txt";
```

Массив `args` это аргументы командной строки (например, вот [дока][cli-args] от микромягких, листать нужно почти до раздела *Спецификация языка*).
* Посмотреть как добавить в [Visual Studio][cli-args-mvs]
* Посмотреть как добавить в [Rider][cli-args-rider]

Просто так и код чище и вообще, расположение файлов на задачу не влияет.

## Linq
Первый мой вариант решения был с использованием `System.Linq`, мне удалось объяснить что происходит, но первая реакция была:
> Я не понимаю

Далее я оставлю примеры методов, которые у меня были с использованием `System.Linq`.

```csharp
public void Read()
{
    using (StreamReader inputStream = File.OpenText(InputFile))
    {
        Numbers = inputStream.ReadLine()
                             .Split(',')
                             .Take(N4) // Выбираем N4 штук элементов
                             // берем каждый и применяем к нему инструкцию в скобках
                             .Select(numberString => int.Parse(numberString))
                             .ToArray();
    }
}
```

```csharp
public void RemoveAllAfter(int borderNumber)
{
    Numbers = Numbers
              // берем элементы пока условие выполняется
              .TakeWhile(number => number != borderNumber)
              // добавляем граничный элемент в конец, т.к. он не был записан
              .Append(borderNumber)
              .ToArray();
}
```

```csharp
public void Remove44()
{
    Numbers = Numbers
              // берем все, которые соответствуют условию в скобках
              .Where(number => number != 44)
              .ToArray();
}
```

```csharp
public void MakeCirclePermutations()
{
    for (int i = 0; i < 6; i++)
    {
        Numbers = Numbers
                  .Skip(1) // пропускаем 1й элемент
                  .Append(Numbers[0]) // добавляем его в конец
                  .ToArray();
    }
}
```

[cli-args]: https://docs.microsoft.com/ru-ru/dotnet/csharp/fundamentals/program-structure/main-command-line#command-line-arguments
[cli-args-mvs]: https://devpractice.ru/c-sharp-command-line-args/#p2
[cli-args-rider]: https://www.jetbrains.com/help/rider/Get_Started_with_Run_Debug_Configurations.html#step-1-understand-run-debug-configurations