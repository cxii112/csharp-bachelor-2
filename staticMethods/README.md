# Статика

Ну просто расскажу что знаю сам и так, как понимаю это сам.

С# для каждого класса хранит его статический экземпляр, с **только** статическими полями и методами. Нестатический экземпляр создается нами, когда мы создаем переменную это типа, статический автоматически при запуске программы. 

Т. к. где искать статику C#-у известно, то вызывать статику из статики, статику из не статики мы можем свободно. Вот что подсказывает IDE если навести на `Console.Write`. 

![][static-method-eg]

Т. к. вызвать не статику мы можем только создав экземпляр класса, C# не знает где искать нестатические методы и поля. **Поэтому non-static члены не видны в static методах**. `static` не регулирует видимость напрямую, это следствие. 

Вот примеры от норм челов (наверное), а не меня:

- [Habr][habr-eg]
- [Metanit][metanit-eg]

Вот, например, класс матрицы.

![][static-members-eg]

Подчеркнуты **static** методы, все остальные методы -- не статические. Вот "код" на C#:

```csharp
namespace staticMethods
{
    public class Matrix
    {
        /* где-то тут мы храним данные матрицы */
        
        public static Matrix Unary(int m, int n)
        {
            /* возвращаем матрицу размера m на n 
             * с 1 на главной диагонали 
             */
        }

        public static Matrix Zero(int m, int n)
        {
            /* возвращаем матрицу m на n
             * из нулей 
             */
        }

        public int Det()
        {
            /* Находим определитель матрицы */
        }

        public Matrix Transpose()
        {
            /* транспонируем матрицу */
        }
    }
}
```

Предположим, что создали 2 матрицы.

![][static-non-static-relations]

Вот так будет храниться наш класс в памяти.



[static-members-eg]: ../sources/static-members-eg.svg
[static-non-static-relations]: ../sources/static-non-static-relations.svg
[static-method-eg]: ../sources/static-method-eg.png
[habr-eg]: https://habr.com/ru/post/206082/
[metanit-eg]: https://metanit.com/sharp/tutorial/3.6.php