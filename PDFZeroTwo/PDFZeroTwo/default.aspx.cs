using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace PDFZeroTwo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

        public void PDF()
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string baseFileName = "hello.pdf";
            string filePath = GetUniqueFilePath(desktopPath, baseFileName);

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2);
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            PDF();

        }
    }
}