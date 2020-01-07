using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class Board
    {
        public int Height { get; }
        public int Width { get; }

        private Dictionary<Point, Tile> tiles;
        
        public List<Tile> NeighboringTiles(Tile tile)
        {
            List<Tile> tileList = new List<Tile>();
            for(int x = tile.location.X - 1; x <= tile.location.X + 1; x++)
            {
                for (int y = tile.location.Y - 1; y <= tile.location.Y + 1; y++)
                {
                    Point point = new Point(x, y);
                    if(InBounds(point))
                    {
                        tileList.Add(tiles[point]);
                    }
                }
            }
            return tileList;

        }

        public bool InBounds(Point point)
        {
            return point.X < Width && point.X >= 0 && point.Y >= 0 && point.Y < Height;
        }
    }
}
