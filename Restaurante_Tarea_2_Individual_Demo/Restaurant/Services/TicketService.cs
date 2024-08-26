using Restaurant.Models;
using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Restaurant.Services
{
    public class TicketService
    {
        public void GenerarPDF(TicketEventArgs e, string filePath)
        {
            try
            {
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
                document.Open();

                // Añadir contenido al PDF
                document.Add(new Paragraph($"Ticket - Mesa: {e.MesaSeleccionada}"));
                document.Add(new Paragraph(" "));
                document.Add(new Paragraph("Detalles de la Orden:"));

                foreach (var item in e.Items)
                {
                    document.Add(new Paragraph($"{item.Key}: {item.Value} unidades"));
                }

                document.Add(new Paragraph(" "));
                document.Add(new Paragraph($"Total: ${e.Total}"));

                document.Close();
            }
            catch (Exception ex)
            {
                // Manejar posibles errores al generar el PDF
                Console.WriteLine($"Error al generar el PDF: {ex.Message}");
            }
        }
    }
}
