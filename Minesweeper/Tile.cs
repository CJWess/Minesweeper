using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Tile
    {
        public int NumericValue { get; }
        public bool IsMine { get; }

        public Point location;

        public Tile(Board board)
        {
            NumericValue = GetValue(board);
        }
        

        public int GetValue(Board board)
        {
            return board.NeighboringTiles(this).Count(x => x.IsMine);
        }
    }
}
