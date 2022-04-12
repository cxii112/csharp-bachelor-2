# Информация
Я решил, что к каждому решению (папке) буду делать подобный файл-гайд. Так что открыв папку листай ниже, ищи гайд.

## Ссылки на работы
* [Статические методы(ауд)][static-methods-aud]
* [Статические методы(СРС)][static-methods-cpc]

## Загрузка
Чтоб загрузить нажми на зеленую кнопку `Code ▼`.

![Загрузка архива][pic1]

В выпадающем меню можно выбрать `Open with Visual Studio` или `Download ZIP`.

![Выбор варианта загрузки][pic2]

Я рекомендую выбирать *второй* вариант.

<details>
  <summary>
    Каждая папка - отдельный проект. (Нажми для подробностей)
  </summary>
  Если открыть целиком всю папку <code>csharp-bachelor-2</code>, скорее всего возникнет конфликт (из-за множества точек входа), между проектами, не проверял. Связано это исключительно с тем, как работает C#.
</details>

После того, как архив скачан и распакован выбирай папку с нужной работой. Заходи в неё и дабл-клик на `.sln` файл. IDE сама его откроет, и подтянет настройки.

[Яоткрыл, но что-то не так с окнами и вообще все не то][fixes]

[Я скачал, но ничего не работает][fixes]

## Для пользователей Rider
Для [Rider][rider] юзеров есть удобная кнопка `Clone in Rider`.

![Закрузка через Rider][pic3]

Но я рекомендую скачивать архив (см. выше почему).

## Extra
Как получить **бесплатную студенческую** лицензию на [Rider][rider] и не [только][features] читай [тут][guide].


[pic1]: ./sources/download.png
[pic2]: ./sources/download-2.png
[pic3]: ./sources/download-3.png

[rider]: https://www.jetbrains.com/rider/
[features]: https://www.jetbrains.com/community/education/#students/faq
[guide]: ./educational-license.md
[fixes]: ./fixes.md

[static-methods-aud]: ./tree/main/staticMethods/
[static-methods-cpc]: ./tree/main/staticMethods_CPC/