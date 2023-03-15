using Lab2_SOLID;


//Вивід грошей до першого завдання
Dolar dolar = new Dolar(100, 5);
dolar.PrintMoney();
Console.WriteLine();


int count = 0;
//Створив репорт
Reporting reporting = new Reporting();
//Створив об'єкт з грошима
Money money1 = new Money(10, 50);
Money money2 = new Money(9, 50);
//Створив об'єкт з товарами
Product product1 = new Product(1, "Кава", money1);
Product product2 = new Product(2, "Ковбаса", money2);
//Склад де лежить товар
Warehouse warehouse1 = new Warehouse(1, "кг", 7, product1, new DateTime(2023, 3, 12));
Warehouse warehouse2 = new Warehouse(2, "кг", 14, product1, new DateTime(2023, 3, 10));
//Додавання в репорт та змінна данни на складі
reporting.AddReport(warehouse1);
reporting.AddReport(warehouse2);

count = warehouse2.AddCountProduct(5);
reporting.AddReport(warehouse1, "Add", count);

count = warehouse1.AddCountProduct(4);
reporting.AddReport(warehouse1, "Add", count);

count = warehouse2.RemoveCountProduct(1);
reporting.AddReport(warehouse1, "Remove", count);

count = warehouse1.RemoveCountProduct(3);
reporting.AddReport(warehouse1, "Remove", count);


//Вивід репорта на екран
reporting.PrintReport();
