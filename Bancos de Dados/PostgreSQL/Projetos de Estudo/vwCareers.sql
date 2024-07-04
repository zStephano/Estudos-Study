CREATE OR REPLACE VIEW vwCareers AS
SELECT
    c.Id,
    c.Title,
    c.Url,
    COUNT(ci.Id) AS Courses
FROM
    Career c
    INNER JOIN CareerItem ci ON c.Id = ci.CareerId
GROUP BY
    c.Id,
    c.Title,
    c.Url;
