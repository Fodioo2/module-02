using System;

namespace ln1
{
    class program
    {
        public void Method(string type, string message)
        {
            Console.WriteLine(type + ": " + message);
        }
        static void Main()
        {
            program p = new program();
            p.Method("Info", "This is a sample message.");
            p.Method("Warning", "This is a warning message.");
            p.Method("Error", "This is an error message.");

        }
    }
}
