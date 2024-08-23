using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba02
{
    /// <summary>
    /// Summary description for PdfHandler
    /// </summary>
    public class PdfHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var pdfGenerator = new PDFExample01(); // Ensure you have this class
            //var pdfBytes = pdfGenerator.GenerarPdf();

            context.Response.ContentType = "application/pdf";
            context.Response.AddHeader("Content-Disposition", "attachment; filename=SampleDocument.pdf");
            //context.Response.BinaryWrite(pdfBytes);
            context.Response.End();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}