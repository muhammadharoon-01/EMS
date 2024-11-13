using System;
using System.Diagnostics;
using System.Reflection;

class Program
{
    static string workingDirectoryPath = "C:\\Program Files (x86)\\Smart Wires\\SmartInterface\\SmartInterface.exe";
    //static string workingDirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase).Substring(6);


    static void Main(string[] args)
    {
        try
        {
            var startInfo = new ProcessStartInfo
            {

                FileName = workingDirectoryPath,
                //FileName = Path.Combine(workingDirectoryPath, "EMSApplication.exe"), // or your application's path
                UseShellExecute = true,  // Ensures the process is created with an interactive shell
                CreateNoWindow = false, // Ensures the window is visible
                WindowStyle = ProcessWindowStyle.Normal // Forces the process to open in a normal window
            };

            Process process = Process.Start(startInfo);
            process.WaitForExit(); // Optional: to wait for the process to exit before continuing
        }
        catch (Exception ex)
        {
            Console.WriteLine("The process could not be started: " + ex.Message);
        }
    }
}
