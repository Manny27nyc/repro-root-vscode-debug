using System;
using System.IO;

namespace repro_root_vscode_debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World, I am running as '{Environment.UserName}'! Attempting to read in the mounted nuget packages from /root/.nuget/packages");
            try
            {
                var files = Directory.GetFiles("/root/.nuget/packages");
                Console.WriteLine($"Found {files.Length} in /root/.nuget/packages");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to get NuGet packages from /root/.nuget/packages. `n{ex}");
            }
        }
    }
}
