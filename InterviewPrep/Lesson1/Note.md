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



---------------------

# <span style="color:#818cf8;"></span>

<span style="color:#fbbf24; font-weight:bold;"></span>

```csharp
```