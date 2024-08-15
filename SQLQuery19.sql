DECLARE @carne VARCHAR(20), @carrera VARCHAR(5), @semestre VARCHAR(10), @codigoCurso VARCHAR(5)
DECLARE miCursor CURSOR FOR SELECT Carne, SUBSTRING(Carne, 4, 2) AS Carrera, SUBSTRING(Carne, 0, 3) AS Semestre FROM Alumno
OPEN miCursor
	FETCH NEXT FROM miCursor INTO @carne, @carrera, @semestre
	WHILE (@@FETCH_STATUS = 0)
	BEGIN
		IF LEN(@carne) = 8
            BEGIN
                DECLARE @idSemestre VARCHAR(5)
                
                If @semestre = '20' SET @idSemestre = 1
                If @semestre = '19' SET @idSemestre = 3
                If @semestre = '18' SET @idSemestre = 5
                If @semestre = '17' SET @idSemestre = 17

                DECLARE miCursor2 CURSOR
                FOR SELECT * FROM curso WHERE Id_Carrera = @carrera AND Id_Semestre = @idSemestre
                OPEN miCursor2
                    FETCH NEXT FROM miCursor2 INTO @codigoCurso

                    WHILE (@@FETCH_STATUS = 0)
                    BEGIN
                        INSERT INTO Asigna_Curso VALUES(CONCAT(@carne, @codigoCurso), @carne, @codigoCurso, 0, 0, 0, '', '', GETDATE(), GETDATE())
                        FETCH NEXT FROM miCursor2 INTO @codigoCurso
                    END
                CLOSE miCursor2
                DEALLOCATE miCursor2
            END
        ELSE 
            UPDATE Alumno SET estado = 0 WHERE Carne = @carne
        FETCH NEXT FROM miCursor INTO @carne, @carrera, @semestre
	END
CLOSE miCursor
DEALLOCATE miCursor
