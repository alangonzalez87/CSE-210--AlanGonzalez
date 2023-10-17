using System;
using System.Collections.Generic;
using System.IO;

public class Diary
{
    private List<DiaryEntry> entries = new List<DiaryEntry>();

    public void AddEntry(DiaryEntry entry)
    {
        entries.Add(entry);
    }

    public List<DiaryEntry> GetEntries()
    {
        return entries;
    }

    public void ClearEntries()
    {
        entries.Clear();
    }

    public void LoadEntriesFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            entries.Clear();
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        int index = line.IndexOf(" | ");
                        if (index != -1)
                        {
                            string date = line.Substring(0, index);
                            string message = line.Substring(index + 3);
                            DiaryEntry entry = new DiaryEntry(message);
                            entry.Date = date;
                            entries.Add(entry);
                        }
                    }
                }
                Console.WriteLine("Diario cargado con éxito.");
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al cargar el diario: " + e.Message);
            }
        }
        else
        {
            Console.WriteLine("El archivo especificado no existe.");
        }
    }

    public void SaveEntriesToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
            Console.WriteLine("Diario guardado con éxito.");
        }
        catch (IOException e)
        {
            Console.WriteLine("Error al guardar el diario: " + e.Message);
        }
    }
}
