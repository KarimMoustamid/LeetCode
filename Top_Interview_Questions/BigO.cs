namespace Sandbox
{
    using System.Diagnostics;

    public class BigO
    {
        public void FindNemo(string[] NamesArray)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();

            for (int i = 0; i < NamesArray.Length; i++)
            {
                if (NamesArray[i] == "nemo")
                {
                    Console.WriteLine($" I found Nemo !!");
                }
            }

            stopwatch.Stop();
            Console.WriteLine($"Elapsed Time: {stopwatch.ElapsedMilliseconds} ms");
        }

        public int funChallenge(string[] names)
        {
            int a = 10; // O(1)
            a = 50 + 3; // O(1)

            for (int i = 0; i < names.Length; i++) // O(names) , O(n)
            {
                FindNemo(names); // O(n)
                var stanger = false; // O(n)
                a++; // O(n)
            }

            return a; // O(1)


            // = O(3) + O(n) + O(n) + O(n) + O(n)
            // = O(3 + 4n)
            // = O(n)
        }

        public void booo(string? heSaid)
        {
            foreach (var c in heSaid)
            {
                Console.WriteLine("booooo");
            }
        }
    }
}