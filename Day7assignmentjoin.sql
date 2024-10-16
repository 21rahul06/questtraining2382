SELECT Studentbasic.fname,subject.name,marks.mark,exam.max_mark 
FROM STUDENTbasic
INNER JOIN subject
ON STUDENTbasic.id=SUBJECT.id inner join marks on marks.id = SUBJECT.id inner join exam on EXAM.id=SUBJECT.id;

SELECT  subject.name AS subject_name, studentbasic.fname AS student_name, marks.mark
FROM marks
INNER JOIN subject ON marks.subject_id = subject.id
INNER JOIN STUDENTbasic ON marks.student_id = STUDENTbasic.id;

SELECT DISTINCT exam.id AS examid, STUDENTbasic.id AS studentid
FROM STUDENTbasic
INNER JOIN marks ON marks.student_id = STUDENTbasic.id
INNER JOIN exam ON marks.exam_id = exam.id
WHERE STUDENTbasic.id = 1;

