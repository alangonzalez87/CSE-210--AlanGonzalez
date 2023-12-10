using System;

using System.Collections.Generic;


// Clase Programa principal
class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        // Crear instancias de cada tipo de actividad
        Running runningActivity = new Running(new DateTime(2022, 11, 3), 30, 3.0);
        Cycling cyclingActivity = new Cycling(new DateTime(2022, 11, 3), 30, 15.0);
        Swimming swimmingActivity = new Swimming(new DateTime(2022, 11, 3), 30, 10);

        // Agregar las actividades a la lista
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        // Mostrar el resumen de cada actividad en la lista
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
