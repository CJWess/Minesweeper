using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class MinesweeperForm : Form
    {

        public MinesweeperForm(Board board)
        {
            InitializeComponent();
            // ☻☻☻☻ Flowlayoutpanel version ☻☻☻☻
            //add number of buttons equal to width x height of board
            //button sizing is width of layoutpanel / width - (spacing*width) <-for spacing
            //might mean button values will have to correspond with a linear list instead of a grid?


            
            //  ☺☺☺☺ tablelayoutpanel version ☺☺☺☺
            //add columns and rows equal to width and height of board
            //fill each node with a button

            //TableLayoutPanel panel = new TableLayoutPanel();
            //panel.ColumnCount = board.Width;
            //panel.RowCount = board.Height;
            //for (int i = 0; i < panel.ColumnCount; i++)
            //{
            //    panel.Controls.Add(new Label() { Text = "sdflkj" }, i, 0);
            }
        }   
    }
}
