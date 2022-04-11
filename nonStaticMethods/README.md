# non-static
Ну во-первых, я уже писал об этом частично в аудиторной по [статике][static-guide]. Там был пример с классом, содержащим статические и не статические методы.

Наверное может возникнуть вопрос
> "А почему нельзя все писать в `static`, все ж работало?"

Работало кнш. Но, статика не умеет работать с нестатикой, только если создать ее внутри метода.
```csharp
static void Main(string[] args)
{
    // ...
    SomeClass m = new SomeClass();
    m.DoSomething();
    // ...
}
```

Забегая вперед, не статические методы как правило работают с какими-то данными, хранящиеся в **текущем** объекте.
Сколько будет объектов, столько будет наборов таких данных.
Можно было бы написать какой-нибудь метод, который принимал бы данные как параметры и что-то там с ними делал.
Но будь у нас какой-нибудь объект, где этих данных много, да еще и они все разного типа, то нам придется писать их все, как параметры.
Можно сделать финт ушами, засунуть их в коллекцию, но тогда их придется приводить к какому-нибудь примитивному типу, с которым у нас ничего не выйдет, а потом еще и преобразовывать обратно...
Но ведь проще сделать как в примере кода выше.

Открывай форточку.


[static-guide]: ../staticMethods/