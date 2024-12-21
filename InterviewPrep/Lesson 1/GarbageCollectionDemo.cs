namespace InterviewPrep.Lesson1
{
    public class GarbageCollectionDemo
    {
        public static void Run()
        {
            Console.WriteLine("Demo of Garbage Collection in C#");

            // Explicitly showing the start of GC info
            Console.WriteLine($"Initial Gen 0 Collections: {GC.CollectionCount(0)}");
            Console.WriteLine($"Initial Gen 1 Collections: {GC.CollectionCount(1)}");
            Console.WriteLine($"Initial Gen 2 Collections: {GC.CollectionCount(2)}");


            // Create object within a scope
            CreateObjects();

            // Force Garbage Collection
            Console.WriteLine("Forcing GC Collection...");
            GC.Collect();
            GC.WaitForPendingFinalizers();

            // GC info after collection
            Console.WriteLine($"Gen 0 Collections after GC: {GC.CollectionCount(0)}");
            Console.WriteLine($"Gen 1 Collections after GC: {GC.CollectionCount(1)}");
            Console.WriteLine($"Gen 2 Collections after GC: {GC.CollectionCount(2)}");

            Console.WriteLine("Garbage Collection demo completed.");
        }


        static void CreateObjects()
        {
            Console.WriteLine("Creating objects...");
            for (int i = 0; i < 10000000000; i++)
            {
                // Allocate an object that will become unreachable
                var obj = new object();
            } // obj goes out of scope after this block
        }
    }
}