CREATE OR REPLACE FUNCTION spDeleteStudent(student_id UUID) RETURNS VOID AS $$
BEGIN
    -- Inicia a transação
    BEGIN;
    
    -- Exclui os registros da tabela StudentCourse
    DELETE FROM StudentCourse WHERE StudentId = student_id;

    -- Exclui o registro da tabela Student
    DELETE FROM Student WHERE Id = student_id;

    -- Confirma a transação
    COMMIT;
END;
$$ LANGUAGE plpgsql;
