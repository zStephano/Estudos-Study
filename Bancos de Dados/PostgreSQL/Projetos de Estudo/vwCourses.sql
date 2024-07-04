CREATE OR REPLACE VIEW vwCourses AS 
SELECT 
    c.Id,
    c.Tag,
    c.Title,
    c.Url,
    c.Summary,
    c.CreateDate,
    cat.Title AS Category,
    a.Name AS Author
FROM
    Course c
    INNER JOIN Category cat ON c.CategoryId = cat.Id
    INNER JOIN Author a ON c.AuthorId = a.Id
WHERE
    c.Active = TRUE;
