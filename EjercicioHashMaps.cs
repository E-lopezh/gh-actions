using System;
using System.Collections.Generic;
namespace EjerciciosClaude
{
    public class EjercicioHashMaps
    {
        public EjercicioHashMaps()
        {
            
        }
        public int Solucion(int[] arrayTesting)
        {
            //PASO 1. Pasar todos los números del array a un hashset, para eliminar duplicados
            //y buscar si un número existe en el hashset.
            HashSet<int> arrayHash = new HashSet<int>();

            //2. Llenamos el conjunto con los elementos del array
            foreach (int numero in arrayTesting)
            {
                //Solo los números positivos
                if (numero > 0)
                {
                    arrayHash.Add(numero);
                }

            }

            //3. Buscamos el menor número positivo que no esté en el conjunto
            int menorNumeroPositivo = 1;
            while (arrayHash.Contains(menorNumeroPositivo))
            {
                menorNumeroPositivo++;
            }
            //4. Mostramos el resultado
            return menorNumeroPositivo;
        }
    }

}



