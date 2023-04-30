# TestFigure
 
*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

 *- Юнит-тесты*
 
 *- Легкость добавления других фигур*
 
 *- Вычисление площади фигуры без знания типа фигуры*
 
 *- Проверку на то, является ли треугольник прямоугольным"*

# Задача на SQL


###  Создание таблиц:

```
CREATE TABLE Product (
 Id INT PRIMARY KEY,
  "Name" NVARCHAR(MAX)
);

CREATE TABLE Category (
  Id INT PRIMARY KEY,
  "Name" NVARCHAR(MAX)
);

CREATE TABLE ProductCategory (
    Id INT PRIMARY KEY IDENTITY,
 ProductId INT, 
   FOREIGN KEY (ProductId) REFERENCES Product(Id),
 CategoryId INT, 
   FOREIGN KEY (CategoryId) REFERENCES Category(Id),
);
```
  
### Заполнение данных: 
```
INSERT INTO Product
VALUES
	(1, N'Телевизор'),
	(2, N'Яблоко'),
	(3, N'Машина'),
    (4, N'Ковер');
    
INSERT INTO Category
VALUES
	(1, N'Бытовая техника'),
	(2, N'Продукты'),
	(3, N'Транспорт');


INSERT INTO ProductCategory
VALUES
	(1, 1),
	(2, 2),
	(3, 3);
 ```
### Решение: 
```
SELECT P."Name", C."Name"
FROM Product P
LEFT JOIN ProductCategory PC
	ON P.Id = PC.ProductId
LEFT JOIN Category C
	ON PC.CategoryId = C.Id;
 ```
 
### Результат:

<img src="/Assets/result.png" width=700 />
