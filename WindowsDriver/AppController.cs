using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsDriver
{
    public class AppController
    {

        public static (int Id, IntPtr Handle) Launch(string path)
        {
            var info = new ProcessStartInfo
            {
                FileName = path
                //WorkingDirectory = directory,
                //Arguments = arguments
            };

            var process = Process.Start(info);
            Thread.Sleep(1000);
            return (process.Id, process.MainWindowHandle);
        }
    }
}
