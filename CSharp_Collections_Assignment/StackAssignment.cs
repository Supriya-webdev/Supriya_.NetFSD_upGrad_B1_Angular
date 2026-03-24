using System;
using System.Collections.Generic;
using System.Text;

namespace C__Collections_Assignment
{
    internal class StackAssignment
    {
        static void Main()
        {

            Stack<string> actions = new Stack<string>();
            Stack<string> redo = new Stack<string>(); 

            actions.Push("Type A");
            actions.Push("Type B");
            actions.Push("Delete C");
            actions.Push("Type D");

            Console.WriteLine("Undo last 3 actions:");
            for (int i = 0; i < 3; i++)
            {
                string action = actions.Pop();
                redo.Push(action);
                Console.WriteLine("Undo: " + action);
            }

            Console.WriteLine("Current Top Action: " + actions.Peek());

            Console.WriteLine("Redo last undone: " + redo.Pop());
        }
    }
}
