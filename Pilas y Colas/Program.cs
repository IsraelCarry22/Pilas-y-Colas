using Pilas_y_Colas.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_y_Colas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //MostrarPila(5);
            MostrarCola(5);
            Console.ReadKey();
        }

        private static void MostrarCola(int size)
        {
            Cola MyQueue = new Cola(size);
            Console.WriteLine("==========================================");
            Console.WriteLine("¿Esta vacia la cola? " + MyQueue.isEmpty());
            MyQueue.Enqueue(2);
            MyQueue.Enqueue(4);
            MyQueue.Enqueue(6);
            Console.WriteLine("==========================================");
            Console.WriteLine("Elemento de frente: " + MyQueue.Front());
            MyQueue.Dequeue();
            MyQueue.Dequeue();
            Console.WriteLine("==========================================");
            Console.WriteLine("Elemento de frente: " + MyQueue.Front());
            MyQueue.Enqueue(8);
            MyQueue.Enqueue(10);
            Console.WriteLine("==========================================");
            Console.WriteLine("isEmpty: " + MyQueue.isEmpty());
            MyQueue.Enqueue(6);
            Console.WriteLine("==========================================");
            Console.WriteLine("Front: " + MyQueue.Front());
            MyQueue.Dequeue();
            MyQueue.Dequeue();
            MyQueue.Dequeue();
            MyQueue.Dequeue();
            Console.WriteLine("==========================================");
            Console.WriteLine("isEmpty: " + MyQueue.isEmpty());
        }

        private static void MostrarPila(int size)
        {
            Pila MyStack = new Pila(size);
            Console.WriteLine("==========================================");
            Console.WriteLine("¿Está vacía la pila?: " + MyStack.IsEmpty());
            MyStack.Push(5);
            MyStack.Push(15);
            MyStack.Push(25);
            MyStack.Push(35);
            MyStack.Push(45);
            Console.WriteLine("==========================================");
            Console.WriteLine("¿Está vacía la pila?: " + MyStack.IsEmpty());
            Console.WriteLine("Elemento Top: " + MyStack.Peek());
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Pop();
            MyStack.Pop();
            Console.WriteLine("==========================================");
            Console.WriteLine("¿Está vacía la pila?: " + MyStack.IsEmpty());
            MyStack.Pop();
            Console.WriteLine("Elemento Top: " + MyStack.Peek());
        }
    }
}