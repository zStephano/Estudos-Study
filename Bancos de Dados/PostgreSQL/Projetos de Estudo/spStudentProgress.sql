CREATE OR REPLACE FUNCTION spStudentProgress (
    student_id UUID
)
RETURNS TABLE (
    student_name NVARCHAR(120),
    course_title NVARCHAR(160),
    progress INT,
    last_update_date TIMESTAMP
)
AS $$
BEGIN
    RETURN QUERY
    SELECT
        s.Name AS student_name,
        c.Title AS course_title,
        sc.Progress,
        sc.LastUpdateDate
    FROM
        StudentCourse sc
        INNER JOIN Student s ON sc.StudentId = s.Id
        INNER JOIN Course c ON sc.CourseId = c.Id
    WHERE
        sc.StudentId = student_id
        AND sc.Progress < 100
        AND sc.Progress > 0
    ORDER BY
        sc.LastUpdateDate DESC;
END;
$$ LANGUAGE plpgsql;
