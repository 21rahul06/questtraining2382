--CREATE TABLE STUDENTbasic (
--   id INT IDENTITY PRIMARY KEY,
--    fname VARCHAR(50) NOT NULL,
--    class VARCHAR(50) NOT NULL,
--    email VARCHAR(100) UNIQUE NOT NULL
--);
--CREATE TABLE SUBJECT (
    name VARCHAR(100) NOT NULL,
   code VARCHAR(10) NOT NULL UNIQUE
);
INSERT INTO STUDENTbasic (fname, class, email)
VALUES
('John', '11', 'john.doe@mail.com'),
('Jane', '1A', 'jane.smith@mail.com'),
('Alice', '12', 'alice.johnson@mail.com');
INSERT INTO SUBJECT (name, code) VALUES ('Mathematics', 'MAT101'), ('Physics', 'ITT001'),
('Chemistry', 'ITT101');
CREATE TABLE EXAM (
    id INT IDENTITY PRIMARY KEY,
    min_mark DECIMAL(5, 2) NOT NULL ,
    max_mark DECIMAL(5, 2) NOT NULL 
);

INSERT INTO EXAM (min_mark, max_mark)
VALUES
(0, 100),
(0, 50),
(0, 150);