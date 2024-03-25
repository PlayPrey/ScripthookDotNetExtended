using GTA.Native;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScripthookDotNetExtended
{
    public static class Game
    {
        [Description("Pauses the game. This does NOT display the pause screen.")]
        public static void PAUSE_GAME()
        {
            Function.Call("PAUSE_GAME");
        }
        [Description("Unpauses the game.")]
        public static void UNPAUSE_GAME()
        {
            Function.Call("UNPAUSE_GAME");
        }
    }
}
