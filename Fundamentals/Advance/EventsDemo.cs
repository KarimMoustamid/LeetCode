namespace Fundamentals.Advance
{
    public class EventsDemo
    {
        // Step 1: Define a delegate (a blueprint for methods that can handle the event)
        public delegate void SampleEventHandler(string message);

        // Step 2: Declare the event using the delegate
        public event SampleEventHandler SampleEvent;

        // Step 3: Method to trigger the event
        public void RaiseEvent(string message)
        {
            // Check if there are subscribers
            if (SampleEvent != null)
            {
                // Raise the event
                SampleEvent(message);
            }
        }

        // Step 4: Example of using the event
        public static void Demo()
        {
            // Instantiate the class
            var demo = new EventsDemo();

            // Subscribe to the event
            demo.SampleEvent += (msg) => { Console.WriteLine($"Event received with message: {msg}"); };

            // Trigger the event
            demo.RaiseEvent("Hello, Events in C#!");
        }
    }
}