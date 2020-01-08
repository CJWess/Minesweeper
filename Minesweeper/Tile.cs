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
        public Point Location { get; }
        public bool HasBeenRevealed { get; set; }

        public Tile(Board board, Point location, bool isMine)
        {
            NumericValue = GetValue(board);
            Location = location;
            IsMine = isMine;
        }

        public int GetValue(Board board)
        {
            return board.NeighboringTiles(this).Count(x => x.IsMine);
        }
    }
}
