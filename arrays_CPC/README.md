# Массивы (СРС)

## Linq
Первый мой вариант решения был с использованием `System.Linq`, мне удалось объяснить что происходит, но первая реакция была:
> Я не понимаю

Вот например как выглядел метод `PrintAllEven`:
```csharp
private static void PrintAllEven(int[] source)
{
    // int[] evens = Array.FindAll(source, number => number % 2 == 0);
    int[] evens = source.Where(number => number % 2 == 0).ToArray();
    Print(evens, "Четные элементы");
}
```

[cli-args]: https://docs.microsoft.com/ru-ru/dotnet/csharp/fundamentals/program-structure/main-command-line#command-line-arguments
[cli-args-mvs]: https://devpractice.ru/c-sharp-command-line-args/#p2
[cli-args-rider]: https://www.jetbrains.com/help/rider/Get_Started_with_Run_Debug_Configurations.html#step-1-understand-run-debug-configurations