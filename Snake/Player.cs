using System;
using Snake.Controls;


namespace Snake.Player
{
    public class Player
    {
        public string Name { get; private set; }
        public int PlayerID { get; private set; }
        public Controls.Controls Controls { get; set; } = new Controls();
    }
}
