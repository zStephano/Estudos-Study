-- Desconecte do banco de dados atual (se estiver conectado)
\q

-- Conecte ao banco de dados "postgres" (ou outro banco de dados de administração)
\c postgres

-- Encerre todas as conexões ativas com o banco de dados "Curso"
SELECT pg_terminate_backend (pg_stat_activity.pid)
FROM pg_stat_activity
WHERE pg_stat_activity.datname = 'Curso';

-- Exclua o banco de dados "Curso"
DROP DATABASE Curso;
