# Описание реализации

## Что сделано:
- Создан репозиторий, в репозитории создана отдельная [папка](https://github.com/vaskalka/C-)
- Описана псевдо [блок-схема](https://yapx.ru/album/WHRI8) - не вижу смысла реализовывать полную блок-схему, т.к. алгоритм в целом понятен и весьма прост. 
- Добавлен файл описания .md
- Реализован программный код на C# (используются массивы, функция по подсчету элементов массив реализована с оптимизацией затрачиваемой памяти, выделяемой под новый массив)
- Программное решение удовлетворяет ТЗ по пункту 5 (несколько [комитов](https://github.com/vaskalka/C-/commits/master))

## Реализация методов:
- **FillArray** с типом void.
Заполнение массива в цикле пользователем, размерность которого введена пользователем и хранится в ArrayLength.

- **PrintArray** с типом void.
Вывод массива в цикле, заполненного пользователем.

- **NewArrayLessOrEquallyThreeSimbols** с типом void.
Первым шагом подсчитывает общее кол-во элементов, удовлетворяющих поставленному в ТЗ условию (<= 3), в введенном массиве, после чего записывает полученное число в переменную "Counter" с типом int. Переменная "Counter" используется в шаге два, с её помощью задается определенная размерность массива, с целью экономии памяти. В новый массив размерностью "Counter" записываются элементы, удовлетворяющие условию (<= 3). Их количество будет равно "Counter".
