# <span style="color:#818cf8;">What is .NET</span>

- **.NET**:  
  .NET is a Microsoft framework used for building, deploying, and running applications.  
  It includes the following:
    - **CLR (Common Language Runtime)**: Manages code execution.
    - **FCL (Framework Class Library)**: Provides a large library of reusable functionality.

  It supports multiple programming languages and enables cross-platform development.---

# <span style="color:#818cf8;">.NET Framework vs .NET Core vs .NET</span>

- **.NET Framework**:  
  A Windows-only implementation of .NET primarily used for building Windows desktop and server-based applications.

- **.NET Core**:  
  A cross-platform, open-source framework used for modern app development, supporting Windows, macOS, and Linux.

- **.NET (or .NET 5+)**:  
  The unified successor of .NET Core, combining features of both frameworks for cross-platform development.

# <span style="color:#818cf8;">What is IL</span>

IL stands for <span style="color:#fbbf24; font-weight:bold;">Intermediate Language</span>, also commonly referred to as
MSIL (Microsoft Intermediate Language) in the context
of .NET development. It is a low-level, human-readable programming language to which .NET source code (written in
languages like C#, F#, VB.NET, etc.) is compiled before it is executed.

# <span style="color:#818cf8;">What is JIT</span>

JIT, or Just-In-Time compiler, is a  <span style="color:#fbbf24; font-weight:bold;">component of the Common Language
Runtime (CLR)</span> in the .NET framework that transforms
Intermediate Language (IL) code into machine-specific native code during program execution.

# <span style="color:#818cf8;">Common Language Runtime (CLR)</span>

The Common Language Runtime (CLR) is the <span style="color:#fbbf24; font-weight:bold;">execution engine</span> and the
core component of Microsoft’s .NET framework. It acts
as a runtime environment for executing .NET applications and provides essential services such as memory management,
security, exception handling, and garbage collection.

# <span style="color:#818cf8;">What is the Garbage Collector</span>

The Garbage Collector (GC) is an <span style="color:#fbbf24; font-weight:bold;">automatic memory management
mechanism</span>
provided by the Common Language Runtime (CLR) in
.NET. It is responsible for managing the allocation and deallocation of memory for objects in a .NET application while
ensuring efficient memory use and preventing memory leaks.

# <span style="color:#818cf8;">What is the CTS</span>

The <span style="color:#fbbf24; font-weight:bold;">Common Type System</span> (CTS) is a foundational component of the
.NET. It is primarily responsible for defining and enforcing how data types are declared, used, and managed in the
runtime environment.

# <span style="color:#818cf8;">What is CLS</span>

The <span style="color:#fbbf24; font-weight:bold;">Common Language Specification</span> (CLS) is a component of the
.NET. It defines a subset of rules that sets the minimum standard for features and data types that all .NET-compliant
languages need to follow in order to achieve interoperability.

# <span style="color:#818cf8;">What are Stack and Heap</span>

In computer programming, particularly in .NET and other modern programming environments, the Stack and Heap are two
types of memory areas used for storing and managing data during application runtime.

# <span style="color:#818cf8;">What are Value Types and Reference Types</span>

In .NET (including C#), <span style="color:#fbbf24; font-weight:bold;">Value Types and Reference Types</span> are the
two primary categories of data types.

- <span style="color:#16a34a; font-weight:bold;">Primitive and Struct Types:</span>
    - int, float, double, bool, char, etc
    - struct types and enum types.

- <span style="color:#16a34a; font-weight:bold;">Reference Types :</span>
    - A Reference Type holds a reference (or memory address) to the actual data stored in heap memory.

# <span style="color:#818cf8;">Boxing & Unboxing </span>

- <span style="color:#fbbf24; font-weight:bold;">Boxing</span> is the process of converting a value type (e.g., int,
  float, struct) into a reference type (object).

```csharp
int num = 42;              // Value type stored in stack
object boxedNum = num;     // Boxing: Value type is wrapped into a reference type (object)
```

- <span style="color:#fbbf24; font-weight:bold;">Unboxing</span> is the reverse process of converting a reference type (
  object) back into a value type.

```csharp
object boxedNum = 42;      // Boxing: Value type converted to reference type (object)
int num = (int)boxedNum;   // Unboxing: Object cast back to value type
```

# <span style="color:#818cf8;">Casting, Implicit casting , Explicit Casting</span>

Casting refers to the process of converting a value from one data type to another. In C#, there are two primary types of
casting:

- <span style="color:#fbbf24; font-weight:bold;">Implicit Casting</span> (Safe Casting)
    - mplicit Casting happens automatically by the compiler when there is no risk of losing data. when converting a
      smaller data type to a larger data type (e.g., int to long, float to double).

- <span style="color:#fbbf24; font-weight:bold;">Explicit Casting</span> (Forced Casting)
    - Explicit Casting is required when there is a possibility of data loss or when converting from a larger data type
      to a smaller data type (e.g., double to int) or between incompatible types. In C#, this is done using casting
      operators like <span style="color:#dc2626; font-weight:bold;">(type)</span> .

# <span style="color:#818cf8;">Array & ArrayList</span>

- <span style="color:#fbbf24; font-weight:bold;">Array</span> : Strongly types , size fixed

- <span style="color:#fbbf24; font-weight:bold;">ArrayList</span>  : flexible and not Strongly types

# <span style="color:#818cf8;">Generic Collection</span>

- <span style="color:#fbbf24; font-weight:bold;">Generics Collections</span> are Strongly types and flexible

# <span style="color:#818cf8;">Threads</span>

A thread is the smallest unit of a process that can be scheduled and executed independently. A thread exists within a
process, and every process has at least one thread, often called the main thread.

Threads are used to achieve <span style="color:#fbbf24; font-weight:bold;">concurrent execution</span> in a program.

<span style="color:#16a34a; font-weight:bold;">Threads are often used along with asynchronous programming for handling
non-blocking operations</span>.

# <span style="color:#818cf8;">Thread Vs Task</span>

Task are an abstraction for managing asynchronous work over threads. they actually use parallel processing

- Use Thread if you need direct control over thread operations.
- Prefer Task for higher-level asynchronous programming.

# <span style="color:#818cf8;">Exceptions</span>

In C#, exceptions are handled using <span style="color:#fbbf24; font-weight:bold;">try, catch, and optionally
finally</span> blocks

```csharp
try
{
    // Code that might throw an exception
}
catch (ExceptionType ex)
{
    // Code to handle that exception
}
finally
{
    // Code that always executes (optional)
}

```

<h3 style="background-color: #881337; color: white;display: inline-block;">Garbage Collector (GC)</h3>

The Garbage Collector (GC) is an <span style="background-color: #eab308; color: black;"> automatic memory management system provided by the Common Language Runtime (CLR)</span> in
.NET. It ensures efficient memory usage by managing the allocation and deallocation of objects in memory, helping to
prevent memory leaks and improve application performance.

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">How the Garbage Collector Works</h4>

1. **Allocation:**  
   When a new object is created in a .NET application, the memory required for that object is allocated on the managed
   heap.

2. **Mark-and-Sweep Approach:**  
   The GC identifies which objects are still in use and reclaims the memory used by objects that are no longer reachable
   from the application.

3. **Generational Model:**  
   The GC uses a generational model to optimize memory management. There are three generations:

  - Generation 0: Newly allocated objects.
  - Generation 1: Objects promoted from Generation 0 (usually because they survived GC cycles).
  - Generation 2: Long-lived objects (those that have survived multiple GC cycles).

   <span style="background-color: #16a34a; color: black;">Objects in higher generations are less frequently collected,
   reducing performance overhead.</span>

4. **Compaction:**  
   After reclaiming memory, the GC may compact the heap to ensure that used memory is contiguous, which improves
   allocation performance for new objects.

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">Key Features of Garbage Collector</h4>

- <span style="background-color: #16a34a; color: black;">Automatic Memory Management:</span> Developers don’t need to
  manually allocate or free memory, as the GC handles this automatically.

- <span style="background-color: #16a34a; color: black;">Optimization:</span> The GC optimizes memory usage and
  minimizes the application's working set.

- <span style="background-color: #16a34a; color: black;">Concurrency:</span> GC runs independently of the application
  code and works on a separate thread to minimize interruptions to the application.

<br>

---

<h4 style="background-color: #be185d; color: white;display: inline-block;">When Does the GC Run?</h4>

The Garbage Collector runs automatically when:

1. There is not enough memory for an allocation.
2. The GC determines that running a collection would improve memory usage.
3. The application is explicitly instructed to run the GC by calling `GC.Collect()` (though this is not recommended in
   most cases).

<br>

---
<h3 style="background-color: #881337; color: white;display: inline-block;">Delegates in C#</h3>

In C#, a <span style="background-color: #16a34a; color: black;">delegate</span> is a type that <span style="background-color: #eab308; color: black;"> represents references
to methods </span> with a specific parameter list and return type. Delegates are similar to function pointers in C++ but are
type-safe and object-oriented.

<h4 style="background-color: #be185d; color: white;display: inline-block;">Key Features of Delegates</h4>

- <span style="background-color: #16a34a; color: black;">Type-Safe:</span> Delegates ensure that only methods with the
  correct signature can be assigned to them.
- <span style="background-color: #16a34a; color: black;">Object-Oriented:</span> Delegates are objects and derive from
  the `System.Delegate` class.
- <span style="background-color: #eab308; color: black;"> Delegates can be used to pass methods as parameters and enable callback functionality.</span>

<h4 style="background-color: #be185d; color: white;display: inline-block;">Declaring and Using a Delegate</h4>

Below is an example of defining, instantiating, and using a delegate in C#:

```csharp
using System;

// Define a delegate
delegate int MathOperation(int a, int b);

class Program
{
    static void Main()
    {
        // Assign methods to the delegate
        MathOperation addition = Add;
        MathOperation multiplication = Multiply;

        // Invoke the delegate
        Console.WriteLine($"Addition Result: {addition(10, 5)}");        // Output: 15
        Console.WriteLine($"Multiplication Result: {multiplication(10, 5)}");  // Output: 50
    }

    // Methods matching the delegate signature
    static int Add(int x, int y) => x + y;
    static int Multiply(int x, int y) => x * y;
}
```

<h4 style="background-color: #be185d; color: white;display: inline-block;">Multicasting with Delegates</h4>

Delegates in C# support multicasting, meaning they can reference multiple methods at once. When such a delegate is
invoked, all referenced methods are executed in sequence.

```csharp
using System;

delegate void Notify();

class Program
{
    static void Main()
    {
        // Multicast delegate
        Notify notifications = NotifyUser;
        notifications += LogNotification;

        // Invoke delegate
        notifications();
    }

    static void NotifyUser()
    {
        Console.WriteLine("User has been notified.");
    }

    static void LogNotification()
    {
        Console.WriteLine("Notification logged.");
    }
}
```

<h4 style="background-color: #be185d; color: white;display: inline-block;">Using a delegate for a callback</h4>


```csharp
using System;

delegate void OperationCompleted(string message);

class Program
{
    static void Main()
    {
        // Passing the callback method to PerformOperation
        PerformOperation(10, 5, "Addition", OnOperationCompleted);
    }

    static void PerformOperation(int a, int b, string operationType, OperationCompleted callback)
    {
        int result;
        switch (operationType)
        {
            case "Addition":
                result = a + b;
                break;
            case "Subtraction":
                result = a - b;
                break;
            default:
                callback("Unknown operation type");
                return;
        }

        // Perform the callback once the operation is complete
        callback($"Operation {operationType} completed. Result: {result}");
    }

    static void OnOperationCompleted(string message)
    {
        Console.WriteLine(message);
    }
```