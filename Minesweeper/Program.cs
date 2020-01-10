using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Board board = new Board(new Point(0, 0), 10, 9, 9);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MinesweeperForm(board));
        }
    }
}
