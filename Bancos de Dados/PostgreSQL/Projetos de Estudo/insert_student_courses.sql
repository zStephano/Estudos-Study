INSERT INTO Student (Id, Name, Email, Document, Phone, Birthdate, CreateDate)
VALUES (
    'c55390d4-71dd-4f3c-b978-d1582f51a327',
    'André Baltieri',
    'hello@balta.io',
    '12345678901',
    '11999999999',
    NULL,
    CURRENT_TIMESTAMP
);

INSERT INTO StudentCourse (CourseId, StudentId, Progress, Favorite, StartDate, LastUpdateDate)
VALUES (
    '5d8cf396-e717-9a02-2443-021b00000000',
    'c55390d4-71dd-4f3c-b978-d1582f51a327',
    50,
    FALSE,
    '2021-01-15 12:35:54',
    CURRENT_TIMESTAMP
);
