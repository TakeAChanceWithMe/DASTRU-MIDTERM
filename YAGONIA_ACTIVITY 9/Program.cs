using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAGONIA_ACTIVITY_9
{
    class Program
    { 
        //Stack initialized as empty (NULL)
        static List<int> stack = new List<int>();

        static void Main()
        {
            int choice = 0;

            while (choice != 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n===== STACK MENU =====");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. IsEmpty");
                Console.WriteLine("5. Count");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Push();
                            break;
                        case 2:
                            Pop();
                            break;
                        case 3:
                            Peek();
                            break;
                        case 4:
                            IsEmpty();
                            break;
                        case 5:
                            Count();
                            break;
                        case 6:
                            Console.WriteLine("\nProgram terminated.");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nInvalid menu choice.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nInvalid input! Please enter a number.");
                    Console.ResetColor();
                }
            }
            Console.ReadKey();
        }

        static void Push()
        {
            try
            {
                Console.Write("\nEnter integer to push: ");
                int value = int.Parse(Console.ReadLine());

                stack.Add(value); // insert at top (end of list)
                Console.WriteLine("\nPushed: " + value);
            }
            catch (FormatException)
            {    
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nInvalid input! Only integers allowed.");
                Console.ResetColor();
            }
        }

        static void Pop()
        {
            try
            {
                if (stack.Count == 0)
                throw new InvalidOperationException("\nStack Underflow! Stack is empty.");

                int topValue = stack[stack.Count - 1];
                stack.RemoveAt(stack.Count - 1);
                 
                Console.WriteLine("\nPopped: " + topValue);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void Peek()
        {
            try
            {
                if (stack.Count == 0)
                throw new InvalidOperationException("\nStack is empty.");
                Console.WriteLine("\nTop element: " + stack[stack.Count - 1]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void IsEmpty()
        {
            if (stack.Count == 0)
            Console.WriteLine("\nStack is EMPTY.");
            else
            Console.WriteLine("\nStack is NOT EMPTY.");
        }

        static void Count()
        {
            Console.WriteLine("\nTotal elements in stack: " + stack.Count);
        }
    }
}
