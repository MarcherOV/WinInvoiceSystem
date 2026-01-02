using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;

public class PdfService
{
    public void GenerateInvoice(string path, string number, string clientName, decimal amount, string currency, decimal rate)
    {
        PdfDocument document = new PdfDocument();
        document.Info.Title = "Faktura " + number;

        PdfPage page = document.AddPage();
        XGraphics gfx = XGraphics.FromPdfPage(page);

        // Шрифти
        XFont titleFont = new XFont("Verdana", 20);
        XFont bodyFont = new XFont("Verdana", 12);

        // Малювання тексту
        gfx.DrawString("Faktura VAT", titleFont, XBrushes.Black, new XRect(0, 20, page.Width, page.Height), XStringFormats.TopCenter);

        int y = 80;
        gfx.DrawString($"Numer: {number}", bodyFont, XBrushes.Black, 40, y); y += 20;
        gfx.DrawString($"Data: {DateTime.Now.ToShortDateString()}", bodyFont, XBrushes.Black, 40, y); y += 40;

        gfx.DrawString($"Odbiorca: {clientName}", bodyFont, XBrushes.Black, 40, y); y += 40;

        gfx.DrawString($"Kwota: {amount} {currency}", bodyFont, XBrushes.Black, 40, y); y += 20;
        gfx.DrawString($"Kurs {currency}: {rate}", bodyFont, XBrushes.Black, 40, y); y += 20;

        decimal plnValue = amount * rate;
        gfx.DrawString($"Wartość w PLN: {plnValue:F2} PLN", bodyFont, XBrushes.Black, 40, y);

        document.Save(path);
    }
}
