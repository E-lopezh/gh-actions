using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EjerciciosClaude
{
    public class ContadorMil
    {
        public async Task ContadorMill()
        {
            int total = 0;
            var tareas = new List<Task>();
            for (int i = 0; i < 1000; i++)
            {
                tareas.Add(Task.Run(() => { Interlocked.Increment(ref total); }));
            }
            await Task.WhenAll(tareas);
            Console.WriteLine(total);

        }
    }

}
