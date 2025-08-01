using System.Runtime.InteropServices;

helloZig();
Console.WriteLine("Hello C#!");

[DllImport("ziglib")] static extern void helloZig();