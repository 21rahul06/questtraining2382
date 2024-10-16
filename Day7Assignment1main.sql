CREATE TABLE MARKS (
    id INT IDENTITY PRIMARY KEY,
    exam_id INT NOT NULL,
    subject_id INT NOT NULL,
    mark DECIMAL(5, 2) NOT NULL,
    student_id INT NOT NULL,
    CONSTRAINT FK_marks_subject FOREIGN KEY (subject_id) REFERENCES SUBJECT(id),
    CONSTRAINT FK_marks_student FOREIGN KEY (student_id) REFERENCES STUDENTbasic(id),    CONSTRAINT FK_marks_exam FOREIGN KEY (exam_id) REFERENCES EXAM(id)
);

INSERT INTO MARKS (exam_id, subject_id, mark, student_id) VALUES (1, 1, 85.5, 1),(2, 2, 45.0, 1),  (3, 3, 78.0, 1);

select* from marks