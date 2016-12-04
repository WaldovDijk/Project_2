using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    class Room : AbstractGame
    {
        private string picture = "";
        private Bitmap Achtergrond_2 = new Bitmap();
        private Bitmap Achtergrond_4 = new Bitmap();

        public void main()
        {

        }
        public override void GameStart()
        {
        }
        public override void Update()
        {

        }
        public override void Paint()
        {
            if (room == 0)
            {
                GAME_ENGINE.DrawBitmap(Achtergrond_2, 0, 0);
            }
            if (room == 1)
            {
                GAME_ENGINE.DrawBitmap(Achtergrond_4, 0, 0);
            }
            
        }
    }
}
