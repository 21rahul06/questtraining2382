INSERT INTO Customer (name, email, adress, dob)
VALUES 
('Alice Smith', 'alice.smith@example.com', '123 Main St', '1990-01-15'),
('Bob Johnson', 'bob.johnson@example.com', '456 Oak St', '1985-05-22'),
('Charlie Brown', 'charlie.brown@example.com', '789 Pine St', '1978-08-30'),
('Diana Prince', 'diana.prince@example.com', '101 Maple St', '1992-11-08');

INSERT INTO Accounts (acc_type, account_nu, cust_id)
VALUES 
('Savings', 'ACC001', 1),
('Checking', 'ACC002', 1),
('Savings', 'ACC003', 2);

-- Withdraw an amount from account 1
INSERT INTO Transactions (account_id, transation_type, amount)
VALUES (1, 'Withdraw', 200.00);

-- Deposit into account 2
INSERT INTO Transactions (account_id, transation_type, amount)
VALUES (2, 'Deposit', 500.00);

-- Transfer from account 3 to account 4
INSERT INTO Transactions (account_id, transation_type, amount, to_account_id)
VALUES (3, 'Transfer', 100.00, 4);

-- Deposit into account 1
INSERT INTO Transactions (account_id, transation_type, amount)
VALUES (1, 'Deposit', 1000.00);

alter table transation alter column to_account_id int not null;

-- delete id having 2
delete from customer where id = 2;

-- updating cust name
update customer 
set name = 'Abc'
WHERE id = 1;
SELECT * FROM customer;

select * from transactions where account_id = 1;
-- Using join 
select transactions.transation, transactions.amount , accounts.account_nu,accounts.acc_type, customer.name from
customer inner join accounts on customer.id=accounts.id inner join transactions on accounts.id = 1;

select * from transactions where transation='Deposit';

-- Transfer from account 1 to account 2
INSERT INTO Transactions (account_id, transation, amount, to_account_id)
VALUES (1, 'Transfer', 100.00, 2);

select* from transactions;