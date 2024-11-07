using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static string workingDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Substring(6);

    static void Main(string[] args)
    {
        try
        {

            ProcessStartInfo processInfo = new ProcessStartInfo
            {
                FileName = Path.Combine(workingDirectoryPath, "EMSApplication.exe"), // Replace with the application or script you want to run
                UseShellExecute = true,
                Verb = "runas" // This prompts the process to run as an administrator
            };

            // Start the process
            Process process = Process.Start(processInfo);
            process.WaitForExit(); // Optional: Waits for the process to complete
        }
        catch (Exception ex)
        {
            Console.WriteLine("The process could not be started: " + ex.Message);
        }
    }
}
