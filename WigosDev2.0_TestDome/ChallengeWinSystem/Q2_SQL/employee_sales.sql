--Given the following data definition, write a query that returns names of employees who have no sales

--Example case
--https://app.testdome.com/files/resources/10/027a09cc-4e15-466a-8151-036a5db62df9.txt
-- Suggested testing environment:
-- http://sqlite.online/

-- Example case create statement:
CREATE TABLE employees (
  id INTEGER NOT NULL PRIMARY KEY,
  name VARCHAR(30) NOT NULL
);

CREATE TABLE sales (
  employeeId INTEGER NOT NULL REFERENCES employees(id), 
  value INTEGER NOT NULL CHECK(value > 0)
);

INSERT INTO employees(id, name) VALUES(1, 'John');
INSERT INTO employees(id, name) VALUES(2, 'Mark');
INSERT INTO employees(id, name) VALUES(3, 'Jane');

INSERT INTO sales(employeeId, value) VALUES(1, 100);
INSERT INTO sales(employeeId, value) VALUES(3, 300);

-- Expected output:
-- name
-- ----
-- Mark

-- Explanation:
-- In this example.
-- John and Jane both have sales. Only Mark has no sales.

--Solucion
SELECT name from employees where id not in (select employeeId from sales)
