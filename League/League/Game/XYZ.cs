using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameEngine
{
    public class League : AbstractGame
    {
        //Buttons
        private Button MainMenu;
        //fonts
        private Font League_Font;

        Movement movement;
        //Puzzle puzzle;
        //Room room2;

        public override void GameStart()
        {
            Cursor.Hide();
            //fonts
            League_Font = new Font("Beaufort for LOL", 12);
            //buttons
            MainMenu = new Button(StartClick, "Let the League begin" , 220, 340, 200, 100);
            MainMenu.SetActive(false);

            //room2 = new Room();
            movement = new Movement();

            //puzzle = new Puzzle();
        }
        public void StartClick()
        {

        }
        public override void GameEnd()
        {
            League_Font.Dispose();
            MainMenu.Dispose();
        }

        public override void Update()
        {
            //puzzle.GameStart();
            //room2.Update();
            movement.Update();
        }

        public override void Paint()
        {
            movement.Paint();
            //room2.Paint();
        }
    }
}
