using System;
namespace GreedyNamespace
{
	public class GreedyAlgorithm
    {   public GreedyAlgorithm()
        {
        }
        //Definimos una estructura ligera para representar cada evento
        private struct Evento: IComparable<Evento>
        {
			public int Inicio { get; }
			public int Fin { get; }

			public Evento(int inicio, int fin)
			{
				Inicio = inicio;
				Fin = fin;
			}

            //Definimos el criterio de ordenamiento: de menor a mayor según el tiempo de finalización
			public int CompareTo(Evento other)
			{
				return this.Fin.CompareTo(other.Fin);
            }
        }
        public int solution(int[] A, int[] B)
        {
            int N = A.Length;
            // Caso de esquina: Si no hay eventos, el máximo es 0
            if (N == 0) return 0;

            // 1. Emparejar los tiempos de inicio y fin en un arreglo de Eventos
            Evento[] eventos = new Evento[N];
            for (int i = 0; i < N; i++)
            {
                eventos[i] = new Evento(A[i], B[i]);
            }

            // 2. Ordenar los eventos por su tiempo de finalización. 
            // Array.Sort utiliza QuickSort/IntroSort, lo que nos da un tiempo de O(N log N)
            Array.Sort(eventos);

            // 3. Seleccionar los eventos usando la estrategia Voraz
            int contadorEventos = 1; // Siempre seleccionamos el primer evento que termina
            int tiempoFinUltimoEvento = eventos[0].Fin;

            // Recorremos los eventos restantes (Tiempo O(N))
            for (int i = 1; i < N; i++)
            {
                // Si el evento actual inicia después o justo cuando termina el anterior, lo tomamos
                if (eventos[i].Inicio >= tiempoFinUltimoEvento)
                {
                    contadorEventos++;
                    tiempoFinUltimoEvento = eventos[i].Fin; // Actualizamos el límite de tiempo
                }
            }

            return contadorEventos;
        }
    }
}
