**PhasmoHelper** - помощник для *[Phasmophobia](https://store.steampowered.com/app/739630/Phasmophobia/)* написанный на C# WinForms
### [Download](https://github.com/blank-ins/PhasmoHelper/raw/main/PhasmoHelper.exe) `v1.3.1.11`

## Интерфейс
* Окно программы всегда находиться по верх других окон, но её можно свернуть в панель задач
* При неправильном функционировании горячих клавиш (*изображение клавиши пустое либо клавиша не читается*) сбросьте настройки при помощи *[горячих клавиш](#горячие-клавиши)*
### Кнопка сброса
При нажатии на кнопку интерфейс программы возвращается в начальное состояние, это показано на скриншотах ниже.

---

### Панель улик
На панеле представлены 6 вомзможных улик                
![улики](https://i.pinimg.com/originals/07/ed/48/07ed48710086b4bf4eea490226459a62.png)

* При выборе одной или нескольких улик, на *[панеле призраков](#панель-призраков)* отобразятся все типы призраков, имеющие данную улику
* Если выбраны две улики, будет дана подсказка о соответсвии улик оставшимся типам призраков
* Когда все три улики указаны, программа определит тип призрака и покажет его описание

![выбор улик](https://i.pinimg.com/originals/03/46/8e/03468eaddb93dd05ca3cade7b8f81ac3.gif)

---

### Панель призраков
На панеле представлены 12 типов призраков, присутсвующих в игре     
![призраки](https://i.pinimg.com/originals/f1/36/77/f13677638286b82a046aeb0f457860b3.png)

При нажатии на название призрака, программа отобразит его улики и описание, повторное нажатие отменяет действие.
![инфа о призраке](https://i.pinimg.com/originals/96/bb/d8/96bbd8084434518bf124e2ada4832245.gif)

---

### Ползунок прозрачности
С помощью этого ползунка вы можете настроить прозрачность окна (*минимально 10%*)
![ggg](https://i.pinimg.com/originals/b2/3b/40/b23b404841b46306b0985dfa1a1405b0.gif)

* Прозрачное окно всё-ещё можно перетягивать по экрану.

---

### Горячие клавиши
Предусмотно 6 горячих клавиш по умолчанию (*цифры от 4 до 0, которые не используются игрой*). Они меняются двойным щелчком по их изображению, и последующим нажатием нужной клавиши. Чтобы сбросить горячие клавиши используйте сочетание клавиш `Shift + F6`, когда окно программы активно.
![хоткеи](https://i.pinimg.com/originals/7f/6a/56/7f6a560480790da5fcb503291d409b6c.gif)

Для блокировки/разблокировки горячих клавиш используйте сочетание клавиш `Shift + F7` когда программа активна

## Прочее:
Связаться со мной вы можете через дискорд - `sq1blank#1024`
Если вы нашли баг, если имеются предложения по программе, пишите [здесь](https://github.com/blank-ins/PhasmoHelper/issues)

Список идей которые планируются или уже реализованы:
- [x] Описание призраков `v1.3.1.3`
- [x] Подстветка недостающих улик `v1.3.1.4`
- [x] Привязка горячих клавиш `v1.3.1.6`
- [x] Регулировка прозрачности окна `v1.3.1.7`
- [ ] Перенос описания в файл настроек для редактирования без рекомпиляции
- [ ] Автоматическое обновление 
- [ ] Перенос программы на [WPF](https://ru.wikipedia.org/wiki/Windows_Presentation_Foundation)
- [ ] Вынос только панелей [улик](#панель-улик) и [призраков](#панель-призраков) поверх окон, вместо выноса всего прилоежиня
