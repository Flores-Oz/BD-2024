USE [Corto1BD23]
GO

-- Create a temporary table to store the assignments
IF OBJECT_ID('tempdb..#TempAssignments') IS NOT NULL
    DROP TABLE #TempAssignments;

CREATE TABLE #TempAssignments (
    Carne nvarchar(15),
    Id_Curso nvarchar(10),
    Id_Semestre int,
    fecha_asignacion smalldatetime,
    fecha_ingreso_nota smalldatetime
);

-- Declare variables for the cursor
DECLARE @Carne nvarchar(15);
DECLARE @Id_Semestre int;
DECLARE @Id_Curso nvarchar(10);
DECLARE @FechaAsignacion smalldatetime = GETDATE();
DECLARE @FechaIngresoNota smalldatetime = GETDATE();

-- Define the cursor
DECLARE curso_estudiantes CURSOR FOR
SELECT Carne, 
       CASE
           WHEN Carne LIKE '20002%' THEN 1 -- Primero
           WHEN Carne LIKE '19002%' THEN 1 -- Primero
           WHEN Carne LIKE '18002%' THEN 3 -- Tercer
           WHEN Carne LIKE '17002%' THEN 5 -- Quinto
           WHEN Carne LIKE '1602%' THEN 7 -- Séptimo
           WHEN Carne LIKE '1502%' THEN 7 -- Séptimo
           WHEN Carne LIKE '1402%' THEN 7 -- Séptimo
           WHEN Carne LIKE '1302%' THEN 7 -- Séptimo
           ELSE NULL
       END AS Id_Semestre
FROM dbo.Alumno
WHERE Carne LIKE '2000%' OR Carne LIKE '1900%' OR Carne LIKE '1800%' OR Carne LIKE '1700%' OR Carne LIKE '160%' OR Carne LIKE '150%' OR Carne LIKE '140%' OR Carne LIKE '130%';

OPEN curso_estudiantes;

-- Fetch the first row
FETCH NEXT FROM curso_estudiantes INTO @Carne, @Id_Semestre;

-- Loop through all rows
WHILE @@FETCH_STATUS = 0
BEGIN
    -- Insert new assignments into the temporary table
    INSERT INTO #TempAssignments (Carne, Id_Curso, Id_Semestre, fecha_asignacion, fecha_ingreso_nota)
    SELECT
        @Carne,
        Curso.Id_Curso,
        @Id_Semestre,
        @FechaAsignacion,
        @FechaIngresoNota
    FROM dbo.Curso
    WHERE Curso.Id_Semestre = @Id_Semestre;

    -- Fetch the next row
    FETCH NEXT FROM curso_estudiantes INTO @Carne, @Id_Semestre;
END;

-- Clean up the cursor
CLOSE curso_estudiantes;
DEALLOCATE curso_estudiantes;

-- Insert into Asigna_Curso with unique id_alum_curso
-- Ensure unique id_alum_curso values
;WITH UniqueAssignments AS (
    SELECT ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS id_alum_curso,
           Carne,
           Id_Curso,
           fecha_asignacion,
           fecha_ingreso_nota
    FROM #TempAssignments
)
INSERT INTO dbo.Asigna_Curso (id_alum_curso, Carne, Id_Curso, fecha_asignacion, fecha_ingreso_nota)
SELECT id_alum_curso, Carne, Id_Curso, fecha_asignacion, fecha_ingreso_nota
FROM UniqueAssignments
WHERE id_alum_curso NOT IN (SELECT id_alum_curso FROM dbo.Asigna_Curso);

-- Clean up the temporary table
DROP TABLE #TempAssignments;