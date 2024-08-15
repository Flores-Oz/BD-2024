DECLARE @carne VARCHAR(20), 
@carrera VARCHAR(5), 
@semestre VARCHAR(10), 
@codigoCurso VARCHAR(5)

DECLARE miCursor CURSOR FOR 
SELECT Carne, SUBSTRING(Carne, 4, 2) AS Carrera, SUBSTRING(Carne, 1, 2) AS Semestre 
FROM Alumno

OPEN miCursor
FETCH NEXT FROM miCursor INTO @carne, @carrera, @semestre

WHILE (@@FETCH_STATUS = 0)
BEGIN
    IF LEN(@carne) = 8
    BEGIN
        DECLARE @idSemestre VARCHAR(5)
        
        SET @idSemestre = CASE 
                            WHEN @semestre = '20' THEN '1'
                            WHEN @semestre = '19' THEN '3'
                            WHEN @semestre = '18' THEN '5'
                            WHEN @semestre = '17' THEN '17'
                            ELSE NULL
                          END

        IF @idSemestre IS NOT NULL
        BEGIN
            DECLARE miCursor2 CURSOR FOR 
            SELECT CodigoCurso FROM curso WHERE Id_Carrera = @carrera AND Id_Semestre = @idSemestre
            
            OPEN miCursor2
            FETCH NEXT FROM miCursor2 INTO @codigoCurso
            
            WHILE (@@FETCH_STATUS = 0)
            BEGIN
                INSERT INTO Asigna_Curso 
                VALUES(CONCAT(@carne, @codigoCurso), @carne, @codigoCurso, 0, 0, 0, '', '', GETDATE(), GETDATE())
                
                FETCH NEXT FROM miCursor2 INTO @codigoCurso
            END
            
            CLOSE miCursor2
            DEALLOCATE miCursor2
        END
    END
    
    FETCH NEXT FROM miCursor INTO @carne, @carrera, @semestre
END

CLOSE miCursor
DEALLOCATE miCursor
