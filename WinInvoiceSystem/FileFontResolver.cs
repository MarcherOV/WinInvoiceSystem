using PdfSharp.Fonts;
using System;
using System.IO;

public class FileFontResolver : IFontResolver
{
    public string DefaultFontName => "Verdana";

    public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
    {
        // Повертаємо назву шрифту, яку обробимо нижче
        return new FontResolverInfo(familyName);
    }

    public byte[] GetFont(string faceName)
    {
        // Шукаємо файл шрифту у системній папці
        // УВАГА: Тут ми прив'язуємось до файлу verdana.ttf. 
        // Якщо треба жирний, треба додати логіку для verdanab.ttf
        string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "verdana.ttf");

        if (File.Exists(fontPath))
        {
            return File.ReadAllBytes(fontPath);
        }
        else
        {
            // Запасний варіант - Arial
            fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            if (File.Exists(fontPath))
                return File.ReadAllBytes(fontPath);

            throw new FileNotFoundException("Не знайдено системних шрифтів (Verdana або Arial)!");
        }
    }
}