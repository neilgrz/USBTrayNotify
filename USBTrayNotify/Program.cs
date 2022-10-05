using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace USBTrayNotify
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()

        {
            if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
                return;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            USBLogViewExtract();
            USBLogViewRunningCheck();
            Application.Run(new Form1());
        }

        private static void USBLogViewExtract()
        {
            if (!Directory.Exists(Application.StartupPath + "\\USBLogView"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\USBLogView");

                File.WriteAllText(Application.StartupPath + "\\USBLogView\\readme.txt", Properties.Resources.readme);
                File.WriteAllBytes(Application.StartupPath + "\\USBLogView\\USBLogView.exe", Properties.Resources.USBLogView);
                File.WriteAllBytes(Application.StartupPath + "\\USBLogView\\USBLogView.cfg", Properties.Resources.USBLogViewCfg);
                File.WriteAllBytes(Application.StartupPath + "\\USBLogView\\USBLogView_USBTrayNotify.cfg", Properties.Resources.USBLogView_USBTrayNotify);
                File.WriteAllBytes(Application.StartupPath + "\\USBLogView\\USBLogView.chm", Properties.Resources.USBLogViewChm);
            }
        }


        //USBLogView Running Check
        private static string USBLogViewConfigSrc = Application.StartupPath + @"\USBLogView\USBLogView_USBTrayNotify.cfg";
        private static string USBLogViewPath = Application.StartupPath + @"\USBLogView\USBLogView.cfg";
        private static string USBLogViewExePath = Application.StartupPath + @"\USBLogView\USBLogView.exe";
        public static void USBLogViewRunningCheck()
        {
            File.Copy(USBLogViewConfigSrc, USBLogViewPath, true);

            Process[] proc = Process.GetProcessesByName("USBLogView");
            if (proc.Length == 0)
            {
                ProcessStartInfo PSI = new ProcessStartInfo();
                PSI.FileName = USBLogViewExePath;
                PSI.WorkingDirectory = Application.StartupPath;
                Process.Start(PSI);
                Console.WriteLine("PSI.WorkingDirectory: " + PSI.WorkingDirectory);
            }
        }
    }
}
