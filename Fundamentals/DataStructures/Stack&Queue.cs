namespace Fundamentals.DataStructures
{
    public class Stack_Queue
    {

        /// <summary>
        /// Demonstrates the use of a Stack with an example.
        /// </summary>
        public void StackExample()
        {
            // Stack operates on a Last-In-First-Out (LIFO) principle.
            Stack<int> stack = new Stack<int>();

            // Adding elements to the stack
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine("Stack after pushing elements: 10, 20, 30");
            foreach (var item in stack)
            {
                Console.WriteLine(item); // Output: 30, 20, 10
            }

            // Popping the top element
            int topElement = stack.Pop();
            Console.WriteLine($"\nPopped element: {topElement}"); // Output: 30

            // Peeking the top element without removing it
            int peekElement = stack.Peek();
            Console.WriteLine($"Top element after pop: {peekElement}"); // Output: 20
        }

        /// <summary>
        /// Demonstrates the use of a Queue with an example.
        /// </summary>
        public void QueueExample()
        {
            // Queue operates on a First-In-First-Out (FIFO) principle.
            Queue<int> queue = new Queue<int>();

            // Adding elements to the queue
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            Console.WriteLine("Queue after enqueueing elements: 10, 20, 30");
            foreach (var item in queue)
            {
                Console.WriteLine(item); // Output: 10, 20, 30
            }

            // Dequeue the front element
            int dequeuedElement = queue.Dequeue();
            Console.WriteLine($"\nDequeued element: {dequeuedElement}"); // Output: 10

            // Peeking the front element without removing it
            int peekElement = queue.Peek();
            Console.WriteLine($"Front element after dequeue: {peekElement}"); // Output: 20
        }
    }
}