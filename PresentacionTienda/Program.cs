using System;
using System.Windows.Forms;

namespace PresentacionTienda
{
    public class Program
    {
        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new FrmTienda());
        }
    }
}
