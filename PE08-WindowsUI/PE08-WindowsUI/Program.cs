using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

/* Samar Karnani
 * 10/02/20
 * Prof E. Cascioli
 * PE08_Windows UI
 */

namespace PE08_WindowsUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles(); 
            Application.Run(new MyForm());
            
        }
    }
}
