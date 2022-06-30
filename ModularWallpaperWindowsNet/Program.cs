using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ModularWallpaperWindowsNet
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ProcessStartInfo processStartInfo;
            Process process;

            String jarPath = Path.Combine(Environment.GetEnvironmentVariable("APPDATA"), 
                "ModularWallpaper\\ModularWallpaperWindows.jar");
            processStartInfo = new ProcessStartInfo("java", "-jar " + jarPath);
            processStartInfo.CreateNoWindow = true;
            processStartInfo.UseShellExecute = false;

            process = Process.Start(processStartInfo);
        }
    }
}