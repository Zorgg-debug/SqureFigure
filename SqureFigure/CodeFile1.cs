//Условие: В базе данных MS SQL Server есть продукты и категории.
//Одному продукту может соответствовать много категорий,
//в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории».
//Если у продукта нет категорий, то его имя все равно должно выводиться.
//------
//Таблица с именованием продуктов - Products, colums - id <integer>, name<varchar(50)>
//Таблица с категориями Categories, colums  - category_name <varchar(50)>, product_id<int>
//тогда запрос к базе данных будет выглядесть следующим образом:
//select a.name as [Продукт], ct.category_name as [Категория] from Products a left join Categories ct on a.id = sc.product_id

