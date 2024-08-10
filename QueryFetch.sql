declare @idAca nvarchar(15)
declare miCursor cursor for
select aca.id_alum_curso from inscripcion as ins
inner join asigna_cursosalum as aca on aca.ID_Inscripcion = ins.ID_Inscripcion
where ins.id_ciclo = 9
open miCursor
        fetch next from miCursor into @idAca
		while(@@FETCH_STATUS=0)
		BEGIN
		declare @miSuma int, @promedio int
		declare @resul nvarchar(15)
		select @miSuma=SUM(notafinal) from nota
		where id_alum_curso=@idAca
		set @promedio=@miSuma/3
		if(@promedio>=60)
		       set @resul ='Gano'
	      else
			   set @resul ='Perdio'
		update asigna_cursosalum set SumaTotal=@miSuma, Promedio=@promedio, Resultado=@resul	
		where id_alum_curso=@idAca
		fetch next from miCursor into @idAca
		END
close miCursor
deallocate miCursor
