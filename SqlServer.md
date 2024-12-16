<h3 style="background-color: #155e75; color: white;display: inline-block;">Normalization:</h3>

Normalization is a database design technique used to remove redundant data.

Normalization is achieved by splitting tables into two: one for reference data (Master Table) and another for Transaction data.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Denormalization:</h3>


Denormalization is a database design technique aimed at improving search performance.

<h3 style="background-color: #155e75; color: white;display: inline-block;">OLTP (Online Transaction Processing):</h3>


OLTP is a normalization design technique for managing real-time transaction-oriented databases.


<h3 style="background-color: #155e75; color: white;display: inline-block;">OLAP (Online Analitical Processing):</h3>


OLAP is a denormalization design technique for performance-oriented databases.

<h3 style="background-color: #155e75; color: white;display: inline-block;">First Normal Form (1NF):</h3>


In 1NF, each column in a table contains atomic values, ensuring that each piece of data is indivisible.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Second Normal Form (2NF):</h3>


In 2NF, a table is in 1NF, and all columns depend on the table's primary key, eliminating partial dependencies.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Third Normal Form (3NF):</h3>


3NF builds on 2NF by eliminating transitive dependencies, ensuring that every non-key column is functionally dependent on the primary key and not on other non-key columns.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Primary Key:</h3>


A primary key is a column or a set of columns that uniquely identifies each row in a table.


<h3 style="background-color: #155e75; color: white;display: inline-block;"> Unique Key :</h3>

In SQL, a unique key constraint is used to ensure that all values in a column or a group of columns are unique across the table. Here are some key points about unique key constraints:

- A unique key constraint enforces the uniqueness of values in one or more columns, allowing no duplicate values.
- It can be applied to a single column or a combination of columns.
- Unlike primary keys, unique key constraints allow NULL values, but only one NULL value is allowed per column with a unique key constraint.
- Each unique key constraint creates a unique index on the specified column(s).
- Unique key constraints are used to enforce business rules that require specific columns or combinations of columns to have unique values.

<h3 style="background-color: #155e75; color: white;display: inline-block;"> Identity :</h3>

In SQL, an identity property is used to automatically generate unique values for a column. It is commonly used to create auto-incrementing primary keys in a table. Here are some key points about identity in SQL:

- An identity column contains a unique value for each row, <span style="background-color: #fcd34d; color: black;display: inline-block;">generated automatically </span> by the database.
- It is commonly used to create surrogate keys that uniquely identify each row in a table.
- The identity value is automatically generated and managed by the database system.
- The starting value, increment, and seed for the identity column can be specified when defining the column.
- Identity columns are often used as primary keys in tables to ensure uniqueness and facilitate relationships between tables.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Index:</h3>

It allows the database server to quickly find specific rows in a table without scanning the entire table.

> <span style="color:#94a3b8;display: inline-block;">An index is a data structure that improves the speed of data retrieval operations on a database table at the cost of additional writes and storage space.</span>

<h3 style="background-color: #155e75; color: white;display: inline-block;"> Clustered Index:</h3>

A clustered index defines the order in which data is physically stored on disk. Only one clustered index can be created per table as it reorders the table's rows based on the index key. This means the table can be sorted in only one order.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Nonclustered Index:</h3>

A nonclustered index is a separate structure from the actual table that stores the index key and a pointer back to the original table's row. It does not alter the physical order of the table. Multiple nonclustered indexes can exist on a single table, allowing for multiple ways to access the data efficiently.

<h3 style="background-color: #155e75; color: white;display: inline-block;">Function:</h3>

- <span style="background-color: #fcd34d; color: black;display: inline-block;">Are used for conputation </span>
- Functions return a value.
- Functions can be used in SELECT, WHERE, and HAVING clauses.
- Functions cannot affect the state of the database.
- They are called using SELECT statement.
- They can be used to calculate values based on input parameters.}

```sql
CREATE FUNCTION dbo.CalculateTotalPrice(@ProductId INT, @Quantity INT)
RETURNS DECIMAL(10, 2)
AS
BEGIN
    DECLARE @Price DECIMAL(10, 2);
    SELECT @Price = Price FROM Products WHERE ProductId = @ProductId;
    RETURN @Price * @Quantity;
END;

```


```sql
SELECT dbo.CalculateTotalPrice(123, 5) AS TotalPrice;
```

<h3 style="background-color: #155e75; color: white;display: inline-block;">Stored Procedure:</h3>

- <span style="background-color: #fcd34d; color: black;display: inline-block;">Are like a mini programs or scripts stored in a database</span>
- Stored procedures do not return a value (although they can return values via output parameters).
- Stored procedures cannot be used in SELECT, WHERE, and HAVING clauses.
- Stored procedures can affect the state of the database (e.g., insert, update, delete data).
- They are called using EXECUTE or EXEC statement.
- They can contain multiple SQL statements and can execute business logic procedures.


```sql
CREATE PROCEDURE dbo.InsertProduct
    @ProductName NVARCHAR(50),
    @Price DECIMAL(10, 2),
    @StockQuantity INT
AS
BEGIN
    INSERT INTO Products (ProductName, Price, StockQuantity)
    VALUES (@ProductName, @Price, @StockQuantity);
END;
```

```sql
EXEC dbo.InsertProduct 'New Product', 10.99, 100;

```

<h3 style="background-color: #155e75; color: white;display: inline-block;">Triggers:</h3>

> Triggers in SQL are <span style="background-color: #fcd34d; color: black;display: inline-block;">special stored procedures that are automatically executed</span> or fired when certain events occur in a database. Here are some key points about triggers:

- Triggers are associated with a specific table and are defined to automatically perform an action when a specified database operation (insert, update, delete) occurs on the table.
- They can be used to enforce business rules, maintain data integrity, audit changes, or automate tasks.
- Triggers can be set to execute before or after the triggering event.
- They are written using SQL statements and can include conditions, actions, and logic.
- Triggers can be useful for implementing complex database logic that needs to be executed consistently when certain events occur.


```sql
-- AFTER TRIGGER
CREATE TRIGGER UpdateLastModified
ON Products
AFTER UPDATE
AS
BEGIN
    UPDATE Products
    SET LastModified = CURRENT_TIMESTAMP
    WHERE ProductId IN (SELECT ProductId FROM inserted);
END;
```

```sql
-- INSTEAD OF TRIGGER
CREATE TRIGGER InsteadOfInsertOrder
ON Orders
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO Orders (OrderDate, CustomerId)
    SELECT OrderDate, CustomerId
    FROM inserted;

    INSERT INTO OrderDetails (OrderId, ProductId, Quantity)
    SELECT o.OrderId, od.ProductId, od.Quantity
    FROM inserted od
    JOIN Orders o ON o.OrderId = od.OrderId;
END;
```


<h3 style="background-color: #155e75; color: white;display: inline-block;">Transactions:</h3>

In SQL, a transaction is a sequence of one or more SQL statements that are executed as a <span style="background-color: #fcd34d; color: black;display: inline-block;">single unit of work</span>. Here are some key points about transactions:

- Transactions ensure the atomicity, consistency, isolation, and durability (ACID) properties of database operations.
- The ACID properties ensure that database transactions are processed reliably and without errors.
- Atomicity ensures that either all the operations in a transaction are completed successfully or none of them are.
- Consistency ensures that the database remains in a consistent state before and after the transaction.
- Isolation ensures that the operations in one transaction are isolated from other concurrent transactions.
- Durability ensures that the effects of a committed transaction are permanent and can be recovered in case of a system failure.
- Transactions are typically started with a `BEGIN TRANSACTION` statement and can be committed (`COMMIT`) or rolled back (`ROLLBACK`) to undo the changes made during the transaction.


```sql
BEGIN TRANSACTION;

UPDATE Employees
SET Salary = Salary * 1.1
WHERE DepartmentId = 1;

INSERT INTO AuditLog (TransactionType, TableName, Timestamp)
VALUES ('Update', 'Employees', GETDATE());

COMMIT;
```

</br>

---


### <h3 style="background-color: #be185d; color: white;display: inline-block;">Inner Join:</h3>
An INNER JOIN returns rows when there is at least one match in both tables being joined.


```sql
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
```

### <h3 style="background-color: #be185d; color: white;display: inline-block;">Left Join (or Left Outer Join):</h3>
A LEFT JOIN returns all rows from the left table and the matched rows from the right table. If there is no match, NULL values are returned from the right side.


```sql
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
LEFT JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

```

### <h3 style="background-color: #be185d; color: white;display: inline-block;">Right Join (or Right Outer Join):</h3>
A RIGHT JOIN returns all rows from the right table and the matched rows from the left table. If there is no match, NULL values are returned from the left side.


```sql
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
RIGHT JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
```

### <h3 style="background-color: #be185d; color: white;display: inline-block;">Full Join (or Full Outer Join):</h3>
A FULL JOIN returns rows when there is a match in one of the tables. It combines the results of both LEFT JOIN and RIGHT JOIN.


```sql
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
FULL JOIN Customers ON Orders.CustomerID = Customers.CustomerID;

```

### <h3 style="background-color: #be185d; color: white;display: inline-block;">Cross Join:</h3>
A CROSS JOIN (Cartesian join) returns the Cartesian product of the two tables, i.e., all possible combinations of rows from the two tables are returned. It does not have any join condition specified.


```sql
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
CROSS JOIN Customers;
```

### <h3 style="background-color: #be185d; color: white;display: inline-block;">Self-Join:</h3>

A self-join in SQL is a join operation where a table is joined with itself. This is commonly used when you have a table that contains hierarchical data and you need to compare rows within the same table.

Example:
```sql
SELECT e.employee_name AS employee, m.employee_name AS manager
FROM employees e
JOIN employees m ON e.manager_id = m.employee_id;
```

In this example, the `employees` table is self-joined to retrieve the names of employees and their corresponding managers based on the `manager_id` and `employee_id` relationship.

### <h3 style="background-color: #65a30d; color: white;display: inline-block;">Union:</h3>
The UNION operator is used to combine the result sets of two or more SELECT statements. It removes duplicate rows between the various SELECT statements.

#### Types of Union:

1. **UNION:** This includes all the distinct rows from the result sets of the combined queries.

```sql
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers;
```
   
2. **UNION ALL:** This includes all rows from the result sets of the combined queries, including duplicates.

```sql
SELECT City FROM Customers
UNION ALL
SELECT City FROM Suppliers;
```

### <h3 style="background-color: #155e75; color: white;display: inline-block;">Aggregate Functions:</h3>

In SQL, aggregate functions perform operations on a set of values and return a single value:

1. **COUNT:** Returns the number of rows returned by the query.
   
2. **SUM:** Calculates the sum of a set of values.
   
3. **AVG:** Calculates the average of a set of values.
   
4. **MIN:** Returns the minimum value in a set of values.
   
5. **MAX:** Returns the maximum value in a set of values.

```sql
SELECT 
    COUNT(*) AS TotalOrders,
    SUM(Quantity) AS TotalQuantity,
    AVG(Price) AS AveragePrice,
    MIN(Price) AS MinPrice,
    MAX(Price) AS MaxPrice
FROM Orders;
```


### <h3 style="background-color: #155e75; color: white;display: inline-block;">GROUP BY:</h3>

The GROUP BY clause is used in SQL to arrange identical data into groups. It groups rows that have the same values into summary rows.

```sql
SELECT department, SUM(salary) AS total_salary
FROM employees
GROUP BY department;
```

### <h3 style="background-color: #155e75; color: white;display: inline-block;">HAVING Clause:</h3>

The HAVING clause is used in combination with the GROUP BY clause to filter the results of aggregate functions on selected groups.


```sql
SELECT department, SUM(salary) AS total_salary
FROM employees
GROUP BY department
HAVING SUM(salary) > 10000;
```

</br>

---

### <h3 style="background-color: #0f766e; color: white;display: inline-block;">Wildcards:</h3>

In SQL, you can use wildcards like '%' and '_' for pattern matching in the WHERE clause.

- '%' is used to match any sequence of characters.
- '_' is used to match any single character.

Example:
```sql
SELECT column1, column2
FROM table_name
WHERE column1 LIKE 'abc%' OR column2 LIKE '_D';
```

In this example, 'abc%' will match any value starting with 'abc' in column1, and '_D' will match any value with a single character followed by 'D' in column2.


### <h3 style="background-color: #155e75; color: white;display: inline-block;">Aliases in SQL:</h3>

Aliases in SQL are used to give a table or column a temporary name. This is especially useful when you want to make the output of a query more readable or when you have self joins in a query.

Example for column alias:
```sql
SELECT column1 AS alias_name
FROM table_name;
```

Example for table alias:
```sql
SELECT t.column1
FROM table_name AS t;
```

### <h3 style="background-color: #155e75; color: white;display: inline-block;">CASE Statement in SQL:</h3>

The CASE statement in SQL is a conditional statement that allows you to perform different actions based on different conditions.

Syntax:
```sql
SELECT 
    CASE
        WHEN condition1 THEN result1
        WHEN condition2 THEN result2
        ELSE result3
    END AS alias_name
FROM table_name;
```

Example:
```sql
SELECT 
    column1,
    CASE
        WHEN column2 > 10 THEN 'High'
        WHEN column2 > 5 THEN 'Medium'
        ELSE 'Low'
    END AS category
FROM table_name;
```

In this example, based on the value of column2, a corresponding category ('High', 'Medium', 'Low') is assigned to each row.




### <h3 style="background-color: #155e75; color: white;display: inline-block;">Self-Referencing Table in SQL:</h3>

A self-referencing table in SQL is a table that has a foreign key column that references its own primary key column. This is often used to model hierarchical relationships within the same table.

Example:
```sql
CREATE TABLE employees (
    employee_id INT PRIMARY KEY,
    employee_name VARCHAR(50),
    manager_id INT,
    FOREIGN KEY (manager_id) REFERENCES employees(employee_id)
);
```

In this example, the `employees` table has a `manager_id` column that references the `employee_id` column within the same table, establishing a hierarchical relationship between employees and their managers.


### <h3 style="background-color: #1d4ed8; color: white;display: inline-block;">Temporary Tables in SQL Server:</h3>

Temporary tables in SQL Server are tables that exist temporarily for the duration of a session or a transaction. They are useful for storing intermediate results within a specific scope without affecting the actual database tables.

There are two types of temporary tables in SQL Server:
1. **Local Temporary Tables (`#TableName`):**
   - Local temporary tables are only visible to the current session and are automatically dropped when the session ends.
   - They are created using a single `#` sign followed by the table name.

   Example of creating a local temporary table:
   ```sql
   CREATE TABLE #TempTable (
       ID INT,
       Name VARCHAR(50)
   );
   ```

2. **Global Temporary Tables (`##TableName`):**
   - Global temporary tables are visible to all sessions and are dropped when the last session using the table ends.
   - They are created using a double `##` sign followed by the table name.

   Example of creating a global temporary table:
   ```sql
   CREATE TABLE ##GlobalTempTable (
       ID INT,
       Name VARCHAR(50)
   );
   ```

Temporary tables are useful for storing intermediate results in complex queries or procedures and can help improve performance by reducing the need for repeated querying or processing of data.


### <h3 style="background-color: #155e75; color: white;display: inline-block;">Using the BETWEEN Clause in SQL:</h3>

To demonstrate the usage of the `BETWEEN` clause in a query, here is an example:

```sql
SELECT column_name
FROM table_name
WHERE column_name BETWEEN value1 AND value2;
```

You can replace `column_name`, `table_name`, `value1`, and `value2` with actual column and table names, as well as specific values that you want to use in your query. The `BETWEEN` clause allows you to select values within a specified range, including the start and end values.

</br>

---

### <h3 style="background-color: #6d28d9; color: white;display: inline-block;">Subquery in SQL:</h3>

A subquery in SQL is a query nested within another query. It is used to retrieve data that will be used as a condition or result within the main query.

Example:
```sql
SELECT column_name
FROM table_name
WHERE column_name IN (SELECT column_name FROM another_table WHERE condition);
```

In this example, the subquery `(SELECT column_name FROM another_table WHERE condition)` is nested within the main query to retrieve data based on a specific condition. The result of the subquery is used as a filter for the outer query.

### <h3 style="background-color: #6d28d9; color: white;display: inline-block;">Correlated Subquery in SQL:</h3>

A correlated subquery in SQL is a subquery that depends on the outer query for its values. Each row in the outer query is evaluated by the subquery independently.

Example:
```sql
SELECT column_name
FROM table_name t1
WHERE value = (SELECT MAX(column_name) FROM table_name t2 WHERE t2.id = t1.id);
```

In this example, the subquery `(SELECT MAX(column_name) FROM table_name t2 WHERE t2.id = t1.id)` is correlated to the outer query by referencing the `id` column from both `t1` and `t2` aliases. The subquery is evaluated for each row in the outer query.

### <h3 style="background-color: #6d28d9; color: white;display: inline-block;">Join vs. Subquery in SQL:</h3>

**Join:**
- Joins are used to combine rows from two or more tables based on a related column between them.
- Joins are typically more efficient than subqueries for fetching data from multiple tables.
- Different types of joins include INNER JOIN, LEFT JOIN, RIGHT JOIN, and FULL JOIN.

Example of a JOIN:
```sql
SELECT orders.order_id, customers.customer_name
FROM orders
INNER JOIN customers ON orders.customer_id = customers.customer_id;
```

**Subquery:**
- Subqueries are nested queries that are executed independently and their results are used as conditions or values in the main query.
- Subqueries are useful when the result set of the subquery needs to be dynamically generated based on the outer query.
- Subqueries can be correlated, meaning they depend on the outer query for their values.

Example of a Subquery:
```sql
SELECT product_name
FROM products
WHERE price > (SELECT AVG(price) FROM products);
```

In summary, joins are used to combine columns from different tables based on related columns, while subqueries are used when the result of a nested query is needed for filtering or comparison in the main query. Each has its own use cases depending on the required functionality.

</br>

---

### <h3 style="background-color: #65a30d; color: white;display: inline-block;">Common Table Expression (CTE) in SQL Server:</h3>

A Common Table Expression (CTE) is a temporary result set that can be referenced within a SELECT, INSERT, UPDATE, or DELETE statement in SQL Server. It allows you to define a query that can be referenced multiple times within the same SQL statement.

CTEs are defined using the `WITH` keyword followed by the CTE name and the query that defines the CTE. CTEs help improve readability and maintainability of complex SQL queries by breaking them down into smaller, more manageable parts.

Example of using a CTE to find the 3rd highest salary:

```sql
WITH RankedSalaries AS (
    SELECT Salary, ROW_NUMBER() OVER (ORDER BY Salary DESC) AS SalaryRank
    FROM Employee
)
SELECT Salary
FROM RankedSalaries
WHERE SalaryRank = 3;
```

In this example, `RankedSalaries` is the name of the CTE, and it contains the result of ranking salaries using the `ROW_NUMBER()` function. The main query then selects the salary where the rank is equal to 3 from the CTE.


### <h3 style="background-color: #65a30d; color: white;display: inline-block;">Recursive Common Table Expression (CTE) in SQL Server:</h3>

A Recursive Common Table Expression (CTE) is a CTE that calls itself in a recursive manner to iterate over a result set until a certain condition is met. This feature is particularly useful for hierarchical data structures like organizational charts, bill of materials, and parent-child relationships.

To create a recursive CTE, you use the `UNION ALL` clause with the recursive CTE referencing itself in the subsequent part of the query. Here's an example of using a recursive CTE to retrieve all levels of a hierarchical structure:

```sql
WITH RecursiveCTE AS (
    -- Anchor Member (initial query)
    SELECT EmployeeId, EmployeeName, ManagerId, 1 AS Level
    FROM Employees
    WHERE ManagerId IS NULL

    UNION ALL

    -- Recursive Member (subsequent queries)
    SELECT e.EmployeeId, e.EmployeeName, e.ManagerId, rc.Level + 1
    FROM Employees e
    INNER JOIN RecursiveCTE rc ON e.ManagerId = rc.EmployeeId
)
SELECT EmployeeId, EmployeeName, ManagerId, Level
FROM RecursiveCTE;
```

In this example:
- The CTE `RecursiveCTE` starts with the anchor member that selects employees who have no managers (top-level employees).
- The `UNION ALL` is used to combine the results of the anchor and recursive members.
- The recursive member selects employees based on a join with the previous result to form the hierarchy.
- The final `SELECT` statement retrieves all columns from the recursive CTE to show the hierarchical structure with levels.

</br>

---

