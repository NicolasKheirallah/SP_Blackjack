using System;
using System.Windows.Forms;
/// <summary>
/// Written by Nicolas Kheirallah
/// 04-10-2015
/// </summary>
namespace BlackJack
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new blackJackForm());
        }
    }
}
