DECLARE @Carne nvarchar(15);
DECLARE @Id_Semestre int;
DECLARE @Id_Curso nvarchar(10);
DECLARE @FechaAsignacion smalldatetime = GETDATE();
DECLARE @FechaIngresoNota smalldatetime = GETDATE();

DECLARE ZEROONE CURSOR FOR 
SELECT Carne, SUBSTRING(Carne, 1,2) AS SEMESTRE, 
CASE 
        WHEN LEN(CARNE) = 7 THEN SUBSTRING(CARNE, 3, 2)
        ELSE SUBSTRING(CARNE, 4, 2)
    END AS Carrera
FROM     dbo.Alumno


CLOSE ZEROONE
DELLOCATE ZEROONE