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
        public bool HasBeenRevealed { get; private set; }

        public Tile(Board board, Point location, bool isMine)
        {
            NumericValue = GetValue(board);
            Location = location;
            IsMine = isMine;
        }

        public void Activate(Board board)
        {
            // when mine tile is activated: boom
            // when tile with >= 1 adjacent mine is activated: only that tile is activated
            // when tile with 0 adjacent mines is activated: all connected non-mine tiles are activated
            HasBeenRevealed = true;

            if (NumericValue == 0)
            {
                foreach (Tile neighboringTile in board.NeighboringTiles(this))
                {
                    neighboringTile.Activate(board);
                }
            }



            //if tile has been clicked, nothing happens
            //if tile has mine status and is clicked, it is revealed and the game ends !!
            //if the tile is clicked and does not have mine status, the game continues 🚩
            // game ends if mine, if not mine do reveal
            //UNLESS the tile is clicked and does not have mine status, but is the last non-mine tile 🚩
        }

        public int GetValue(Board board)
        {
            return board.NeighboringTiles(this).Count(x => x.IsMine);
        }
    }
}
