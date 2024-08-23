using System;
using QuestPDF.Fluent;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuestPDF.Helpers;
using System.IO;
using Prueba02.PDF;
using Prueba02.DATA;

namespace Prueba02
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Response.Redirect("~/PdfHandler.ashx");
            GenerarPDF();
        }
        private static string GetUniqueFilePath(string directory, string baseFileName)
        {
            string filePath = Path.Combine(directory, baseFileName);
            string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(baseFileName);
            string extension = Path.GetExtension(baseFileName);
            int counter = 1;

            // Verificar si el archivo ya existe y generar un nuevo nombre si es necesario
            while (File.Exists(filePath))
            {
                string newFileName = $"{fileNameWithoutExtension}({counter}){extension}";
                filePath = Path.Combine(directory, newFileName);
                counter++;
            }

            return filePath;
        }
        public void GenerarPDF()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string baseFileName = "hello.pdf";
            string filePath = GetUniqueFilePath(desktopPath, baseFileName);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(20);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(20));

                    page.Header()
                        .Text("Hello PDF!")
                        .SemiBold().FontSize(36).FontColor(Colors.Blue.Medium);

                    page.Content()
                        .PaddingVertical(1)
                        .Column(x =>
                        {
                            x.Spacing(20);

                            x.Item().Text(Placeholders.LoremIpsum());
                            x.Item().Image(Placeholders.Image(200, 100));
                        });

                    page.Footer()
                        .AlignCenter()
                        .Text(x =>
                        {
                            x.Span("Page ");
                            x.CurrentPageNumber();
                        });
                });
            })
 .GeneratePdf(filePath);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string baseFileName = "hello2.pdf";
            string filePath = GetUniqueFilePath(desktopPath, baseFileName);
            using (var context = new DataClasses1DataContext(Conexion.CADENA))
            {
                // Consulta a la base de datos
                var alumnosQuery = from alumno in context.Alumnos
                                   orderby alumno.Nombre1 // Ordena por la propiedad deseada
                                   select alumno;

                // Convertir la consulta a una lista
                var alumnosList = alumnosQuery.ToList();

                // Crear el generador de PDF
                var pdfGenerator = new PdfDocumentGenerator(alumnosList);
                byte[] pdfBytes = pdfGenerator.GeneratePdf();

                // Guardar el PDF en un archivo
                File.WriteAllBytes(filePath, pdfBytes);

                Console.WriteLine("PDF generated and saved as AlumnoReport.pdf");
            }

        }
    }
}