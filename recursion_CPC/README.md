## Рекурсия (СРС)
Ну тут просто нужно аккуратно проследить за вызовами. Вот пример для `AckermannFunction(1, 1)`:

![][ackermann-1-1-eg]

В результате получим 3.

### А теперь немного духоты.
По идее если или *n* или *m* будет отрицательным метод не должен работать. Чтобы это сделать можно нужно метод.

Например, изменить сигнатуру метода на `void AckermannFunction(int n, int m, ref int result)`. Мы можем гарантировать, что из нашего метода метод `AckermannFunction` не будет вызван с отрицательным аргументом.
```csharp
private static void AckermannFunction(int n, int m, ref int result)
{
    if (n < 0 || m < 0) return; // просто выходим

    if (n == 0) result = m + 1;
    if (m == 0) AckermannFunction(n - 1, 1, ref result);
    if (m > 0 && n > 0)
    {
        int temporary = 0;
        AckermannFunction(n, m - 1, ref temporary);
        AckermannFunction(n - 1,
                          temporary,
                          result);
    }
}
```
Ну вроде ок, да? Но по-моему стало сложнее понимать что куда будет записано. Сложность возросла.

Еще можно, например, кидать *ArgumentException*. На мой взгляд это куда проще, но эксепшены нам не давали.
```csharp
private static int AckermannFunction(int n, int m)
{
    if (n < 0) throw new ArgumentException($"n должно быть неотрицательным, получено {n}");
    if (m < 0) throw new ArgumentException($"m должно быть неотрицательным, получено {m}");

    if (n == 0) return m + 1;
    if (m == 0) return AckermannFunction(n - 1, 1);

    return AckermannFunction(n - 1,
                             AckermannFunction(n, m - 1));
}
```
Причем теперь не нужно оставлять `return 0`, который был нужен, чтобы метод гарантированно что-то вернул. Не нужно потому что мы уже проверили *n* и *m* на отрицательность и вышли, когда выкинули исключение. Соответственно и не нужно проверять на положительность, т.к. это единственный вариант, который остался.

[ackermann-1-1-eg]: ../sources/ackermann-1-1-eg.svg