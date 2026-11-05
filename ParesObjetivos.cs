using System;
using System.Collections.Generic;
using System.Text;

namespace EjerciciosClaude
{
    public class ParesObjetivos
    {
        public ParesObjetivos()
        {                                                          
            List<(int, int)>paresObjetivo = BuscarPares(new int[] { 1, 2, 3, 4, 5 }, 7);
            foreach (var par in paresObjetivo)
            {
                Console.WriteLine(par.Item1 + ", " + par.Item2);
            }
        }
        public List<(int, int)> BuscarPares(int[] precios, int objetivo)
        {
            var resultado = new List<(int, int)>();
            HashSet<int> numerosVistos = new HashSet<int>();

            foreach (int precio in precios)
            {
                int complemento = objetivo - precio;

                // Si el complemento existe en los números que ya visitamos
                if (numerosVistos.Contains(complemento))
                {
                    resultado.Add((complemento, precio));
                }

                // Agregar el número actual al conjunto de visitados
                numerosVistos.Add(precio);
            }

            return resultado;
        }
    }
}
