# Решаем проблемы

Здесь я опишу проблемы с которыми можно столкнуться, но для которых найдено решение.

Если возникла проблема и не знаешь как связаться, то переходи [сюда][github-issues]. Создаешь новую *issue*.
![New issue][new-issue]

## Не совпадает фреймворк (`Microsoft.Common.CurrentVersion.targets [MSB3644]`)
Если ты скачал, но ничего не собирается и выдает подобную ошибку:
![Сообщение об ошибке][framework]

Ну очевидно, что можно просто скачать нужную версию фреймворка, как предлагает сообщение.

Навигация:
- [Visual Studio](#visual-studio)
- [Rider](#rider)

### Visual Studio

В *обозревателе решений* находим название проекта (в примере *staticMethods_HT*, оно может отличаться).
![Обозреватель решений][framework-2-mvs]

Жмем правой кнопкой мыши. Выбираем `Свойства`.
![Свойства][framework-2_2-mvs]

В окне выбираем нужный (доступный) фреймворк.
![Выбор фреймворка][framework-2_3-mvs]

### Rider
В *Explorer* (не Internet) находим название проекта (в примере *staticMethods_HT*, оно может отличаться).
![][framework-2-rider]
Жмем правой кнопкой мыши. Выбираем `Properties`.
![Свойства][framework-2_2-rider]

В окне выбираем нужный (доступный) фреймворк.
![Выбор фреймворка][framework-2_3-rider]

### Завершение
Не забываем сохранить проект (полностью) и собрать, чтобы все поничилось.

#### Я хочу усложнить себе жизнь
Нужно переключиться меджу видом (представлениями)

MSVisual: дабл-клик по *Предствление папки*
![Смена представления][framework-2_4-mvs]

Rider: выбираем *File System*
![Смена представления][framework-2_4-rider]

Далее находим файл формата `.csproj`. Меняем
```xml
<TargetFrameworkVersion>v*новый номер версии*</TargetFrameworkVersion>
```
![Изменение руками][framework-2_5]



[github-issues]: https://github.com/cxii112/csharp-bachelor-2/issues

[framework]: ./sources/issue-framework.png

[framework-2-rider]: ./sources/issue-framework-2-rider.png
[framework-2-mvs]: ./sources/issue-framework-2-mvs.png
[framework-2_2-rider]: ./sources/issue-framework-2_2-rider.png
[framework-2_2-mvs]: ./sources/issue-framework-2_2-mvs.png
[framework-2_3-rider]: ./sources/issue-framework-2_3-rider.png
[framework-2_3-mvs]: ./sources/issue-framework-2_3-mvs.png
[framework-2_4-rider]: ./sources/issue-framework-2_4-rider.png
[framework-2_4-mvs]: ./sources/issue-framework-2_4-mvs.png
[framework-2_5]: ./sources/issue-framework-2_5.png

[framework-3-rider]: ./sources/issue-framework-3-rider.png
[framework-3-mvs]: ./sources/issue-framework-3-mvs.png

[new-issue]: ./sources/issue-new-issue.png
