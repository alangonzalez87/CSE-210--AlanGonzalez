using System;

using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        // Crear instancias de videos
        Video video1 = new Video("Alan in the final Proyect", "Alan Gonzalez", 180);
        video1.AddComment("UserA", "Great video!");
        video1.AddComment("UserB", "I learned a lot from this.");

        Video video2 = new Video("The battle for the B", "Alan Gonzalez", 240);
        video2.AddComment("UserC", "Interesting content.");
        video2.AddComment("UserD", "Can you make more videos like this?");

        Video video3 = new Video("C# is my passion", "Alan Gonzalez", 150);
        video3.AddComment("Stevven Traip", "Not a fan of this video.");
        video3.AddComment("UserF", "Could be improved.");

        // Crear una lista de videos
        List<Video> videoList = new List<Video> { video1, video2, video3 };

        // Interacción simulada: Mostrar información para cada video
        foreach (var video in videoList)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.LengthSeconds + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumComments());

            // Mostrar todos los comentarios para el video
            Console.WriteLine("Comments:");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();  // Agregar un salto de línea entre videos
        }
    }
}
