using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame_AzuaraFonseca {

    public enum Direction { Up,Down, Left, Right };
    class Settings {
        public static int Width { get; set; } // Determine the width of the circles (food)
        public static int Height { get; set; } // Determined the height of the circles (food)
        public static int Speed { get; set; } // Determine the speed of the player character
        public static int Score { get; set; } // Determine total of game
        public static int Points { get; set; } // Determine how many points will be added each time an object(circle/food)  is consumed by snake
        public static bool GameOver { get; set; } // As long as its false, game will continue
        public static Direction direction { get; set; }

        public Settings() {
            Width = 25;
            Height = 25;
            Speed = 16;
            Score = 0;
            Points = 100;
            GameOver = false;
            direction = Direction.Down;
        }
    }
}
