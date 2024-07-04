CREATE OR REPLACE FUNCTION spListCourse(
    category_name NVARCHAR(60),
    par2 NVARCHAR(60)
)
RETURNS TABLE (
    Id INT,
    Tag NVARCHAR(20),
    Title NVARCHAR(160),
    Url NVARCHAR(1024),
    Summary NVARCHAR(2000),
    CreateDate TIMESTAMP
)
AS $$
DECLARE
    category_id INT;
BEGIN
    SELECT Id INTO category_id FROM Categoria WHERE Nome = category_name LIMIT 1;

    RETURN QUERY
    SELECT
        c.Id,
        c.Tag,
        c.Title,
        c.Url,
        c.Summary,
        c.CreateDate
    FROM
        Curso c
    WHERE
        c.CategoriaId = category_id;
END;
$$ LANGUAGE plpgsql;
