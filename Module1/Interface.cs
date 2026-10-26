using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1
{

   // implement a chess piece
   interface IChessPiece
    {
        string Name { get; }
        string Color { get; }

        // previous coordinates of the chess piece and new coordinates of the chess piece
        string[] Coordinates { get; set; }
        void Move();
    }

    class ChessPiece : IChessPiece
    {
        public string Name { get; private set; }
        public string Color { get; private set; }

        public string[] Coordinates { get; set; }

        public ChessPiece(string name, string color, string[] coordinates)
        {
            Name = name;
            Color = color;
            Coordinates = coordinates;
        }
        public void Move()
        {
            Console.WriteLine($"{Color} {Name} has moved from {Coordinates[0]} to {Coordinates[1]}.");
        }
    }

    


}
