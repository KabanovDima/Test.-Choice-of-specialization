**ИТОГОВАЯ ПРОВЕРОЧНАЯ РАБОТА**

Данная работа необходма для проверки знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться, что базовое знакомство с IT прошло успешно.

Задача алгомитрически не самая сложная, однако для олноценного выполнения проверочной работы необходимо:
1. Создатьрепозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтиь блок-схемой основной содержательной части, если вы выделяете ее в отдельнй метод)
3. Снабдить репозиторий оформленным текстовым опианием решения (файл README.md)
4. Наисать программу, решающую поставленную задачц
5. Использовать контроль версий в работе над этим небольшим роектом (не должно быть так, что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача** : Написать программу, которая их имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться колекциями, лучше обойтись исключительно массивами.

**Примеры **: 
["hello", "2", "word", ":-)"] => ["2", ":-)"];

**Решение** :
1. Создаем массив с типом string и сразу инициализируем его:
string[] array = {"hello", "2", "word", "my", "-2", "0"};
2. создаем пустой массив размером равным array: string[] array1 = new string[array.Length]; Его будем заполняь данными согласно условию задачи.
3. Создаем метод StringLengthLessThree(string[] array, string[] array1), который принимает на вход массивы array и array 1.
3.1 В методе создаем счетчик, равный 0.
3.2 В методе создаем цикл for (int i = 0; i < array.Length; i++) с условием if(array[i].Length <= 3), в случае выполнения которого в массив array1[i] записываем значение array[i].
Счетчик увеличиваем на 1.

4. Создаем метод печати массиваю
5. Вызываем метод поиска строк меньше либо равных трем, затем вызываем метод печати массива.
