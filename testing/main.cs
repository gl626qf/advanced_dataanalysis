using System;
using Python.Runtime;

namespace PythonAndCSharpIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            PythonEngine.Initialize();
            dynamic py = Py.Import("__main__");
            dynamic locals = py.__dict__;
            dynamic result = PythonEngine.Exec(@"
a = 10
b = 20
sum = a + b
sum
", locals, locals);
            Console.WriteLine("Sum: " + result);
            PythonEngine.Shutdown();
        }
    }
}
