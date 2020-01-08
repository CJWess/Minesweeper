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

        private readonly Dictionary<Point, Tile> tiles;
        private Random random = new Random();

        public Board(Point initialClick, int mineCount, int height, int width)
        {
            Height = height;
            Width = width;

            tiles = new Dictionary<Point, Tile>();

            //make tiles
            // mineCount number of tiles need mines
            // tile at initialClick can't have a mine
        }

        public void InitTiles(Dictionary<Point, Tile> tiles, Point initialClick, int mineCount, int height, int width)
        {
            List<Point> mineLocationList = new List<Point>();

            for (int i = 0; i < mineCount; i++)
            {
                Point randomPoint = new Point(random.Next(0, height + width), random.Next(0, height + width));

                while (randomPoint == initialClick || mineLocationList.Contains(randomPoint))
                {
                    randomPoint = new Point(random.Next(0, height + width), random.Next(0, height + width));
                }

                // we have a Point object that is not initial click
                mineLocationList.Add(randomPoint);
            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Point point = new Point(x, y);
                    Tile tile = new Tile(this, point, mineLocationList.Contains(point));
                    tiles.Add(new Point(x, y), tile);
                }
            }
        }

        public void Activate()
        {
            //if tile has been clicked, nothing happens
            //if tile has mine status and is clicked, it is revealed and the game ends !!
            //if the tile is clicked and does not have mine status, the game continues 🚩
            // game ends if mine, if not mine do reveal
            //UNLESS the tile is clicked and does not have mine status, but is the last non-mine tile 🚩
        }

        public void RevealZeroCostTiles(Tile tile)
        {
            if (tile.NumericValue == 0)
            {
                foreach (Tile neighboringTile in NeighboringTiles(tile))
                {
                    neighboringTile.HasBeenRevealed = true;
                }
                //reveal surrounding tiles, chains for each 0 tile revealed in this way
            }
        }

        public List<Tile> NeighboringTiles(Tile tile)
        {
            List<Tile> tileList = new List<Tile>();
            for(int x = tile.Location.X - 1; x <= tile.Location.X + 1; x++)
            {
                for (int y = tile.Location.Y - 1; y <= tile.Location.Y + 1; y++)
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
