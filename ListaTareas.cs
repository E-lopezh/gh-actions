using System;
namespace EjerciciosClaude
{
    public class ListaTareas
    {
        public ListaTareas()
        {
        }

        public async Task EjecutarTareasAsync()
        {
            var tareas = new List<Task>();

            for (int i = 0; i < 5; i++)
            {
                int valor = i;  // Crear una copia local de i
                tareas.Add(Task.Run(() => Console.WriteLine(valor)));
            }
            await Task.WhenAll(tareas);
        }
    }
}