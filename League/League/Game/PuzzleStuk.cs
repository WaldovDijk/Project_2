using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class PuzzleStuk
    {
        private GameEngine GAME_ENGINE;
        public PuzzleStuk()
        {

        }

        public void Update()
        {
            //1,1
            if (Snap[0] == false && m_Een[0] == false)
            {
                if ((xPositie >= CurrentX1_1 && xPositie <= CurrentX1_1 + 101) && (yPositie >= CurrentY1_1 && yPositie <= CurrentY1_1 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[0] == false)
                    {
                        linksGeklikt[0] = true;
                    }
                }
                if (linksGeklikt[0] == true)
                {
                    for (i = 0; i < 24; i++)
                    {
                        m_Een[i] = true;
                        m_Een[0] = false;
                    }
                    CurrentX1_1 = xPositie - 50;
                    CurrentY1_1 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX1_1 = muisPositie.X - 50;
                        CurrentY1_1 = muisPositie.Y - 50;
                        linksGeklikt[0] = false;
                        for (i = 0; i < 24; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX1_1 >= X_Locked[0] && CurrentX1_1 <= X_Locked[0] + 40) && (CurrentY1_1 >= Y_Locked[0] && CurrentY1_1 <= Y_Locked[0] + 40))
                        {
                            CurrentX1_1 = X_Locked[0];
                            CurrentY1_1 = Y_Locked[0];
                            Snap[0] = true;
                        }
                    }
                }
            }
        }
        public void Paint()
        {

        }
    }
}
