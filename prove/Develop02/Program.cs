using System;

public class Program
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