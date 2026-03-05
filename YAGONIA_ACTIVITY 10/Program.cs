using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static YAGONIA_ACTIVITY_10.Queue;

namespace YAGONIA_ACTIVITY_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initializing the queue as empty (Object-Oriented approach)
            MyQueue myQueue = new MyQueue();
            int choice = 0;

            while (choice != 7)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n===== QUEUE MENU (FIFO) =====");
                Console.WriteLine("\n1. Enqueue (Add to Rear)");
                Console.WriteLine("2. Dequeue (Remove from Front)");
                Console.WriteLine("3. Front (Peek Front)");
                Console.WriteLine("4. Rear (Peek Rear)");
                Console.WriteLine("5. IsEmpty");
                Console.WriteLine("6. Count");
                Console.WriteLine("7. Exit");
                Console.Write("\nEnter choice: ");

                try
                {
                    if (!int.TryParse(Console.ReadLine(), out choice))
                        throw new FormatException();

                    switch (choice)
                    {
                        case 1:
                            Console.Write("\nEnter integer to enqueue: ");
                            int val = int.Parse(Console.ReadLine());
                            myQueue.Enqueue(val);
                            break;
                        case 2:
                            int dequeued = myQueue.Dequeue();
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\nDequeued: {dequeued}");
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\nFront element: {myQueue.Front()}");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\nRear element: {myQueue.Rear()}");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine(myQueue.IsEmpty() ? "\nQueue is EMPTY." : "\nQueue is NOT EMPTY.");
                            break;
                        case 6:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine($"\nTotal elements in queue: {myQueue.Count()}");
                            break;
                        case 7:
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("\nProgram terminated.");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            PrintErrorMessage("Invalid menu choice. Kindly pick a number from the choices given only.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintErrorMessage("Invalid input! Please enter a valid integer.");
                    Console.ResetColor();
                }
                catch (InvalidOperationException ex)
                {
                    PrintErrorMessage(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintErrorMessage("An error occurred: " + ex.Message);
                    
                }
            }
            Console.ReadKey();
        }

        static void PrintErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{message}");
            
        }
    }
}
