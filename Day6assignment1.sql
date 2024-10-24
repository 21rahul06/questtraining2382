CREATE TABLE courses (
    enrollment_id INT IDENTITY PRIMARY KEY,
    course_id INT NOT NULL,
    course_name VARCHAR(50) NOT NULL,
    student_id INT NOT NULL,
    course_fee DECIMAL(10, 2) NOT NULL
);

INSERT INTO courses (course_id, course_name, student_id, course_fee) VALUES
(1, 'Mathematics', 101, 500.00),
(1, 'Mathematics', 102, 500.00),
(2, 'Science', 103, 600.00),
(2, 'Science', 104, 600.00),
(3, 'English', 105, 550.00),
(3, 'English', 106, 550.00),
(4, 'History', 107, 450.00),
(5, 'Geography', 108, 500.00),
(5, 'Geography', 109, 500.00),
(4, 'History', 110, 450.00);

SELECT course_name, COUNT(student_id) AS total_students_enrolled
FROM courses
GROUP BY course_name;

SELECT course_name, SUM(course_fee) AS total_fees_collected
FROM courses
GROUP BY course_name;

SELECT TOP 1 course_name, COUNT(student_id) AS total_students_enrolled
FROM courses
GROUP BY course_name
ORDER BY total_students_enrolled DESC;