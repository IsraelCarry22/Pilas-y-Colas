using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_y_Colas.Clases
{
    class Pila
    {
		private int[] vector;
		private int top;
		private int maxSize;

		public int _MAX_SIZE
		{
			get { return maxSize; }
			set { maxSize = value; }
		}

		public int _TOP
		{
			get { return top; }
			set { top = value; }
		}

		public int[] _VECTOR
		{
			get { return vector; }
			set { vector = value; }
		}

		public Pila(int val)
		{
            maxSize = val;
            vector = new int[maxSize];
			top = -1;
		}

		public void Push(int val)
		{
			if (top < maxSize -1)
			{
				top++;
				vector[top] = val;
                Console.WriteLine($"{val} insertado en la pila.");
            }
			else
			{
                Console.WriteLine("No se puede insertar el elemento.");
            }
		}
        public void Pop()
        {
            if (top >= 0)
            {
                int ProperValue = vector[top];
                top--;
                Console.WriteLine($"Valor {ProperValue} Sacado de la pila");
            }
            else
            {
                Console.WriteLine("No se puede insertar el elemento.");
            }
        }

        public int Peek()
        {
            if (top >= 0)
            {
                return vector[top];
            }
            else
            {
                Console.WriteLine("La pila está vacía");
                return -1;
            }
        }
        
        public bool IsEmpty()
        {
            return top == -1;
        }
    }
}