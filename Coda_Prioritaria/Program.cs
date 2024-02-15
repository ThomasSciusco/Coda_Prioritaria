using System;
using System.Collections;
using System.Collections.Generic;

namespace Coda_Prioritaria
{
    public class CodaPrioritaria<T> where T : IComparable<T>
    {
        private ArrayList elements;

        public CodaPrioritaria()
        {
            elements = new ArrayList();
        }

        public void Inserisci(T elemento)
        {
            if (elements.Count == 0)
            {
                elements.Add(elemento);
                return;
            }

            int indice = TrovaIndiceDiInserimento(elemento);
            elements.Insert(indice, elemento);
        }

        public bool Ricerca(T elemento)
        {
            return elements.Contains(elemento);
        }

        public T Peek()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("La coda prioritaria è vuota.");
            }
            return (T)elements[0];
        }

        public T EstraiPrimo()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("La coda prioritaria è vuota.");
            }
            T primo = (T)elements[0];
            elements.RemoveAt(0);
            return primo;
        }

        public T EstraiUltimo()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("La coda prioritaria è vuota.");
            }
            T ultimo = (T)elements[elements.Count - 1];
            elements.RemoveAt(elements.Count - 1);
            return ultimo;
        }

        public bool IsEmpty()
        {
            return elements.Count == 0;
        }

        private int TrovaIndiceDiInserimento(T elemento)
        {
            int indice = 0;
            foreach (T item in elements)
            {
                if (elemento.CompareTo(item) > 0)
                {
                    indice++;
                }
                else
                {
                    break;
                }
            }
            return indice;
        }
    }
}
