using System;

using System.Collections.Generic;
using System.IO;

class DiaryEntry
{
    public string Message { get; set; }
    public string Date { get; set; }

    public DiaryEntry(string message)
    {
        Message = message;
        Date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
    }

    public override string ToString()
    {
        return $"{Date} | {Message}";
    }
}

class Diary
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

class Program
{
    static void Main(string[] args)
    {
        Diary diary = new Diary();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Diario - Menú:");
            Console.WriteLine("1. Escribir una nueva entrada");
            Console.WriteLine("2. Mostrar el diario");
            Console.WriteLine("3. Guardar el diario en un archivo");
            Console.WriteLine("4. Cargar el diario desde un archivo");
            Console.WriteLine("5. Salir");
            Console.Write("Elija una opción: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.Write("Escriba su entrada: ");
                        string message = Console.ReadLine();
                        DiaryEntry entry = new DiaryEntry(message);
                        diary.AddEntry(entry);
                        break;
                    case 2:
                        ShowDiary(diary);
                        break;
                    case 3:
                        Console.Write("Elija un nombre de archivo para guardar el diario: ");
                        string fileName = Console.ReadLine();
                        diary.SaveEntriesToFile(fileName);
                        break;
                    case 4:
                        Console.Write("Elija un archivo para cargar el diario: ");
                        string loadFileName = Console.ReadLine();
                        diary.LoadEntriesFromFile(loadFileName);
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
            }
        }
    }

    private static void ShowDiary(Diary diary)
    {
        Console.WriteLine("Diario de Entradas:");
        foreach (var entry in diary.GetEntries())
        {
            Console.WriteLine(entry);
        }
    }
}
