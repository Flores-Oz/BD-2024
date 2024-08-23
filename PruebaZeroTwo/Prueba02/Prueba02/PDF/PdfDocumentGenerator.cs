using Prueba02.DATA; // Asegúrate de que este es el namespace correcto para tu clase Alumno
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using System.Collections.Generic;

namespace Prueba02.PDF
{
    public class PdfDocumentGenerator
    {
        private readonly IEnumerable<Alumno> _data;

        public PdfDocumentGenerator(IEnumerable<Alumno> data)
        {
            _data = data;
        }

        public byte[] GeneratePdf()
        {
            var document = Document.Create(container =>
            {
                // Configuración de la página
                container.Page(page =>
                {
                    const float horizontalMargin = 0.3f;
                    const float verticalMargin = 0.6f;

                    // Establecer el tamaño y los márgenes de la página
                    page.Size(PageSizes.A4);
                    page.MarginVertical(verticalMargin, Unit.Inch);
                    page.MarginHorizontal(horizontalMargin, Unit.Inch);

                    // Agregar contenido a la página
                    page.Content().Column(column =>
                    {
                        // Agregar el título en la parte superior
                        column.Item().PaddingVertical(12).Row(row =>
                        {
                            row.AutoItem().Text("Reporte de Alumnos") // Cambia esto si `Conexion.TITULO` es una constante o variable en tu proyecto
                                .FontSize(24)
                                .FontColor(Colors.Red.Medium)
                                .Bold(); // Estilo en negrita para el título
                        });

                        // Espacio adicional debajo del título
                        column.Item().PaddingTop(20);

                        // Agregar la tabla
                        column.Item().Padding(10).Table(table =>
                        {
                            // Definición de columnas
                            table.ColumnsDefinition(columns =>
                            {
                                columns.ConstantColumn(50);  // Carne column
                                columns.RelativeColumn(2);   // Nombre1 column
                                columns.RelativeColumn(2);   // Nombre2 column
                                columns.RelativeColumn(2);   // Apellido1 column
                                columns.RelativeColumn(2);   // Apellido2 column
                                columns.RelativeColumn(2);   // Fecha_Nac column
                                columns.RelativeColumn(2);   // Celular column
                                columns.RelativeColumn(3);   // Email column
                                columns.RelativeColumn(2);   // Estado column
                            });

                            // Encabezado de la tabla
                            table.Header(header =>
                            {
                                header.Cell().Text("Carne").Bold();
                                header.Cell().Text("Nombre1").Bold();
                                header.Cell().Text("Nombre2").Bold();
                                header.Cell().Text("Apellido1").Bold();
                                header.Cell().Text("Apellido2").Bold();
                                header.Cell().Text("Fecha Nac").Bold();
                                header.Cell().Text("Celular").Bold();
                                header.Cell().Text("Email").Bold();
                                header.Cell().Text("Estado").Bold();
                            });

                            // Filas de datos
                            foreach (var item in _data)
                            {
                                table.Cell().Text(item.Carne.ToString());
                                table.Cell().Text(item.Nombre1);
                                table.Cell().Text(item.Nombre2);
                                table.Cell().Text(item.Apellido1);
                                table.Cell().Text(item.Apellido2);
                                table.Cell().Text(item.Fecha_Nac.ToString()); // Formato de fecha
                                table.Cell().Text(item.Celular);
                                table.Cell().Text(item.email);
                                table.Cell().Text(item.estado.Value.ToString());
                            }
                        });
                    });
                });
            });

            return document.GeneratePdf();
        }
    }
}
