Описание алгоритма решения задачи:
1.Создаем и инициализируем массив array1 тип string с 8 элементами и произвольным набором значений: букв, символов и цифр.
2.Создаем и инициализируем массив array2 тип string с объёмом под память равной array1.Length.
3.Создаем метод для сортировки массива ArraySorting тип void с параметрами string[] array1, string[] array2.
4.Создаем переменную element тип int с значением 0 для перемещения в неё отсортированных значенний.
5.Создаем цикл for для перебора всех элементов массива array1, определяем условие сортировки элементов массива Length <= 3, отобранные элементы записываем array2[element] и далее в переменную element++. 
6.Создаем метод PrintArray тип void для вывода на печать массива string[] array2.
7.Создаем цикл for для перебора всех элементов массива array2 и вывода их на консоль.
8.Закрываем оба открытых метода.
Exit