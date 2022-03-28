# Массивы 2 (СРС)

## Метод решения
Ну во-первых, я вертел делать это через `for`, поэтому я использовал мощь `System.Linq` (из-за читаемости). Например:

```csharp
public void RemoveAllAfter(int borderNumber)
    {
        Numbers = Numbers.TakeWhile(number => number != borderNumber)
                         .Append(borderNumber)
                         .ToArray();
    }
```

Возможно, это как-то делается через методы класса `Array`.

Если кто-то сделает через `for` или `Array`, напишите, я добавлю проект с этими решениями.

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


[cli-args]: https://docs.microsoft.com/ru-ru/dotnet/csharp/fundamentals/program-structure/main-command-line#command-line-arguments
[cli-args-mvs]: https://devpractice.ru/c-sharp-command-line-args/#p2
[cli-args-rider]: https://www.jetbrains.com/help/rider/Get_Started_with_Run_Debug_Configurations.html#step-1-understand-run-debug-configurations