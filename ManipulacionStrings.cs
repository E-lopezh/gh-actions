using System;
namespace MapeoStackMaps
{
    public class ManipulacionStrings
    {
        public ManipulacionStrings()
        {
        }

        public bool VerificacionApertura(char[] arrayConcurrency)
        {
            Stack<char> arrayStack = new Stack<char>();
            foreach (char caracter in arrayConcurrency)
            {
                if (caracter.Equals('{') || caracter.Equals('[') || caracter.Equals('('))
                {
                    arrayStack.Push(caracter);
                }
                if (caracter.Equals('}') || caracter.Equals(']') || caracter.Equals(')'))
                {
                    //Si la lista está vacía, significa que no hay un caracter de apertura correspondiente,
                    //por lo que la cadena es inválida
                    if (arrayStack.Count == 0)
                    {
                        return false;
                    }
                    //Si el caracter de cierre no corresponde al caracter de apertura en la cima de la pila,
                    //la cadena no está bien formada, por lo que es inválida.
                    char car = arrayStack.Pop();
                    if ((car == '{' && caracter == '}') || (car == '[' && caracter == ']') || (car == '(' && caracter == ')'))
                    {
                        continue;

                    }
                    else
                    {
                        return false;

                    }

                }

            }
            return (arrayStack.Count == 0) ? true : false;
        }
    }
}
    
