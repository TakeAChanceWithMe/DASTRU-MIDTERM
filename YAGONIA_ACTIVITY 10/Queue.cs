using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_10
{
    internal class Queue
    {
        public class MyQueue // Must be PUBLIC
        {
            private Queue<int> _queue = new Queue<int>();

            public void Enqueue(int value) => _queue.Enqueue(value);

            public int Dequeue()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (_queue.Count == 0) throw new Exception("\nQueue is empty! Cannot dequeue.");
                
                return _queue.Dequeue();
            }

            public int Front()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (_queue.Count == 0) throw new Exception("\nQueue is empty!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                return _queue.Peek();
            }

            public int Rear()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (_queue.Count == 0) throw new Exception("\nQueue is empty!");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                int[] temp = _queue.ToArray();
                return temp[temp.Length - 1];
            }

            public bool IsEmpty() => _queue.Count == 0;

            public int Count() => _queue.Count;

            public void Display()
            {
                if (_queue.Count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Queue is currently empty.");
                    return;
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Current Queue: " + string.Join(" <- ", _queue));
            }
        }
    }
}
