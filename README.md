
Вопрос 2. 
  Библиотека находится в папке Square/bin/Debug/netcoreapp3.1/Square.dll
  В библиотеке создан статический класс, в котором перегружен статический метод GetSquare(). 
  В случае, если пользоваетль передал 1 аргумент - окружность, 3 аргумента - треугольник. Площадь треугольника вычисляется по формуле Герона.
  В случае, если фигура - треугольник, дополнительно проводится проверка на наличие в нем прямого угла с помощью теоремы Пифагора.
  Если треугольник прямоугольный, статическое поле IsRight принимает значение True.
  
  Тесты находятся в папке TestProject
  Тест Circle_Rad1_Ret628() передает в метод GetSquare() радиус 1.0, ожидает площадь 6.28
  Тест Triangle345_Ret6() передает в метод GetSquare() стороны 3.0, 4.0, 5.0, ожидает площадь 6.0 
  Тест Triangle6810_isright() передает в метод GetSquare() стороны 6.0, 8.0, 10.0, ожидает, что треугольник прямоугольный
  
Вопрос 3.
  Предполагая, что категории и товары содержатся в одной таблице, запрос выбирает из таблицы все уникальные пары "Товар-Категория".
