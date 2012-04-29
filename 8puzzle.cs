using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Board
    {
        //Array of tiles
        Tile[] tileBoard;

        //Are tiles in correct positions?
        public Boolean isCorrect()
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != tileBoard[i].getNumber())
                    return false;
            }
            return true;
        }

        //Where is tile on the board?
        public int getLocation(int tileNumber)
        {
            for (int i = 0; i <= 9; i++)
            {
                if (tileBoard[i].getNumber() == tileNumber)
                    return i;
            }
            return -1;
        }

        //What tiles are you next to?
        //ugly, but it works
        public int[] getNeighbors(int tileNumber)
        {
            int location = getLocation(tileNumber);
            int[] neighbors = new int[4];
            int counter = 0;
            if (location + 3 < 9)
                neighbors[counter++] = location + 3;
            if (location - 3 >= 0)
                neighbors[counter++] = location - 3;
            if ((location + 1) / 3 == (location) / 3)
                neighbors[counter++] = location + 1;
            if ((location - 1) / 3 == (location) / 3)
                neighbors[counter++] = location - 1;
            return neighbors;
        }


    }

    //Hold tile information, can add more functionality to it later (images in addition to numbers)
    class Tile
    {
        int number;

        public int getNumber()
        {
            return number;
        }
    }
}
