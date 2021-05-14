using System;
using System.Windows.Forms;
namespace Auto_Machine
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length != 0)
            {
                if (args[0] == "/autorun")
                {
                    AutoMachine mainform = new AutoMachine();
                    Application.Run();
                }
                else
                    Application.Run(new AutoMachine());
            }
            else
                Application.Run(new AutoMachine());
        }
    }
}