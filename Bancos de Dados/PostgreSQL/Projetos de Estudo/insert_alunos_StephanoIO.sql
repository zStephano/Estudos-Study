SELECT * FROM Course;
SELECT * FROM Student;
SELECT * FROM StudentCourse;

INSERT INTO Student (Id, Name, Email, Document, Phone, Birthdate, CreateDate)
VALUES (
    '8de54f78-8aab-45c0-ba06-b412aa4a4cbc',
    'Gustavo Stephano',
    'gustavostephano@hotmail.com',
    '12345678901',
    '12345678',
    NULL,
    CURRENT_TIMESTAMP
);

INSERT INTO StudentCourse (CourseId, StudentId, Progress, Favorite, StartDate, LastUpdateDate)
VALUES (
    '5f5a33f8-4ff3-7e10-cc6e-3fa000000000',
    '8de54f78-8aab-45c0-ba06-b412aa4a4cbc',
    50,
    FALSE,
    '2024-07-03 19:52:50',
    CURRENT_TIMESTAMP
);
