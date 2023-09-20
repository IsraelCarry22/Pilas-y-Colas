using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_y_Colas.Clases
{
    class Cola
    {
		private int[] vector;
		private int front;
		private int rear;
		private int capacity;

		public int _Capasity
		{
			get { return capacity; }
			set { capacity = value; }
		}


		public int _Rear
		{
			get { return rear; }
			set { rear = value; }
		}


		public int _Frente
		{
			get { return front; }
			set { front = value; }
		}


		public int[] _My_Vectro
		{
			get { return vector; }
			set { vector = value; }
		}

		public Cola(int val)
		{
			capacity = val;
			vector = new int[capacity];
			front = rear = -1;
		}

		public void Enqueue(int val)
		{
			if (rear == capacity -1)
			{
				Console.WriteLine("la cola esta llena");
				return;
			}
			if (front == -1)
			{
				front = 0;
			}
			vector[++rear] = val;
			Console.WriteLine($"Elemento {val} encolado en la cola.");
		}

		public int Dequeue()
		{
			if (isEmpty())
			{
                Console.WriteLine("La cola está vacía. No se puede desencolar.");
                return -1;
            }
			int item = vector[front++];
            if (front > rear)
            {
                front = rear = -1;
            }
            Console.WriteLine($"Elemento {item} desencolado de la cola.");
            return item;
        }
        public int Front()
        {
            if (isEmpty())
            {
                Console.WriteLine("La cola está vacía.");
                return -1;
            }

            return vector[front];
        }

        public bool isEmpty()
		{
			return front == -1;
		}
	}
}