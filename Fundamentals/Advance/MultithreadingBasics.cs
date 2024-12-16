namespace Fundamentals.Advance
{
    public class MultithreadingBasics
    {
        // Multithreading Basics in C#
        // Example 1: Creating and starting a thread
        public static void Example1()
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Thread 1: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });

            thread.Start();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Main Thread: {i}");
                Thread.Sleep(500); // Simulate work
            }
        }

        // Example 2: Using Thread.Join to wait for a thread to complete
        public static void Example2()
        {
            Thread thread = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Worker Thread: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });

            thread.Start();
            Console.WriteLine("Waiting for the worker thread to complete...");
            thread.Join(); // Wait for the worker thread to finish
            Console.WriteLine("Worker thread completed.");
        }

        // Example 3: Thread safety using locking
        private static object _lock = new object();
        private static int _counter = 0;

        public static void Example3()
        {
            Thread thread1 = new Thread(IncrementCounter);
            Thread thread2 = new Thread(IncrementCounter);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            Console.WriteLine($"Final Counter Value: {_counter}");
        }

        private static void IncrementCounter()
        {
            for (int i = 0; i < 10; i++)
            {
                lock (_lock) // Ensures thread safety
                {
                    _counter++;
                    Console.WriteLine($"Counter incremented to: {_counter} by {Thread.CurrentThread.ManagedThreadId}");
                    Thread.Sleep(100); // Simulate work
                }
            }
        }


        // Example 4: Thread Priority
        public static void Example6()
        {
            Thread highPriorityThread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"High-Priority Thread: {i}");
                    Thread.Sleep(100); // Simulate work
                }
            });

            Thread lowPriorityThread = new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Low-Priority Thread: {i}");
                    Thread.Sleep(100); // Simulate work
                }
            });

            // Set thread priorities
            highPriorityThread.Priority = ThreadPriority.Highest;
            lowPriorityThread.Priority = ThreadPriority.Lowest;

            highPriorityThread.Start();
            lowPriorityThread.Start();

            highPriorityThread.Join();
            lowPriorityThread.Join();

            Console.WriteLine("Thread priority example completed.");
        }

        // Example 5: Using Task for modern multithreading
        public static async Task Example4()
        {
            Task task1 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Task 1: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });

            Task task2 = Task.Run(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Task 2: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });

            await Task.WhenAll(task1, task2);
            Console.WriteLine("Both tasks completed.");
        }


        // Example 6: Foreground and Background Threads
        public static void Example7()
        {
            Thread foregroundThread = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Foreground Thread: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });

            Thread backgroundThread = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Background Thread: {i}");
                    Thread.Sleep(500); // Simulate work
                }
            });

            // Set the background thread
            backgroundThread.IsBackground = true;

            foregroundThread.Start();
            backgroundThread.Start();

            foregroundThread.Join(); // Wait for the foreground thread to complete

            Console.WriteLine("Foreground thread completed. Note: Background thread may or may not complete.");
        }


        // Example 8: Using ThreadPool
        public static void Example8()
        {
            // Queue a work item to the thread pool
            ThreadPool.QueueUserWorkItem(_ =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"ThreadPool Thread: {i}");
                    Thread.Sleep(500); // Simulate work
                }

                Console.WriteLine("ThreadPool Thread completed.");
            });

            Console.WriteLine("Main thread is continuing...");
            Thread.Sleep(3000); // Allow time for ThreadPool thread to complete
            Console.WriteLine("Main thread completed.");
        }
    }
}