using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class Stuk
    {
        GameEngine m_GameEngine;

        private int xPositie;
        private int yPositie;
        private int x;
        private int y;
        private int move;
        private int LockedX;
        private int LockedY;
        private int win = 0;
        private Bitmap Orb = new Bitmap("Orb.png");
        private Bitmap MiniOrb = new Bitmap("Mini_orb.png");
        private int i;
        private int[,] CurrentX = new int[5,5];
        private int[,] CurrentY = new int[5,5];
        private bool[] linksGeklikt = new bool[25];
        private bool[] Snap = new bool[25];
        private bool[] m_Een = new bool[25];
        private int[] X_Locked = new int[5];
        private int[] Y_Locked = new int[5];
        public Stuk()
        {
            m_GameEngine = GameEngine.GetInstance();
            CurrentX[0, 0] = 100;
            CurrentX[0, 1] = 210;
            CurrentX[0, 2] = 320;
            CurrentX[0, 3] = 430;
            CurrentX[0, 4] = 540;
            CurrentX[1, 0] = 540;
            CurrentX[1, 1] = 210;
            CurrentX[1, 2] = 540;
            CurrentX[1, 3] = 100;
            CurrentX[1, 4] = 430;
            CurrentX[2, 0] = 100;
            CurrentX[2, 1] = 320;
            CurrentX[2, 2] = 100;
            CurrentX[2, 3] = 430;
            CurrentX[2, 4] = 320;
            CurrentX[3, 0] = 100;
            CurrentX[3, 1] = 540;
            CurrentX[3, 2] = 210;
            CurrentX[3, 3] = 540;
            CurrentX[3, 4] = 430;
            CurrentX[4, 0] = 430;
            CurrentX[4, 1] = 210;
            CurrentX[4, 2] = 210;
            CurrentX[4, 3] = 320;
            CurrentX[4, 4] = 320;

            CurrentY[0, 0] = 100;
            CurrentY[0, 1] = 210;
            CurrentY[0, 2] = 320;
            CurrentY[0, 3] = 430;
            CurrentY[0, 4] = 540;
            CurrentY[1, 0] = 100;
            CurrentY[1, 1] = 540;
            CurrentY[1, 2] = 320;
            CurrentY[1, 3] = 430;
            CurrentY[1, 4] = 210;
            CurrentY[2, 0] = 210;
            CurrentY[2, 1] = 540;
            CurrentY[2, 2] = 320;
            CurrentY[2, 3] = 320;
            CurrentY[2, 4] = 100;
            CurrentY[3, 0] = 540;
            CurrentY[3, 1] = 430;
            CurrentY[3, 2] = 100;
            CurrentY[3, 3] = 210;
            CurrentY[3, 4] = 540;
            CurrentY[4, 0] = 100;
            CurrentY[4, 1] = 430;
            CurrentY[4, 2] = 320;
            CurrentY[4, 3] = 210;
            CurrentY[4, 4] = 430;

            X_Locked[0] = 700;
            X_Locked[1] = 800;
            X_Locked[2] = 900;
            X_Locked[3] = 1000;
            X_Locked[4] = 1100;
            //rows Y
            Y_Locked[0] = 150;
            Y_Locked[1] = 250;
            Y_Locked[2] = 350;
            Y_Locked[3] = 450;
            Y_Locked[4] = 550;

        }
        public void Update(int x, int y, int move, int LockedY, int LockedX)
        {
            Vector2 muisPositie = m_GameEngine.GetMousePosition();
            xPositie = muisPositie.X;
            yPositie = muisPositie.Y;

            //1,1
            if (Snap[move] == false && m_Een[move] == false)
            {
                if ((xPositie >= CurrentX[x, y] && xPositie <= CurrentX[x, y] + 101) && (yPositie >= CurrentY[x, y] && yPositie <= CurrentY[x, y] + 101))
                {
                    if (m_GameEngine.GetMouseButtonUp(0) && linksGeklikt[move] == false)
                    {
                        linksGeklikt[move] = true;
                    }
                }
                if (linksGeklikt[move] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[move] = false;
                    }
                    CurrentX[x, y] = xPositie - 50;
                    CurrentY[x, y] = yPositie - 50;
                    if (m_GameEngine.GetMouseButtonUp(1))
                    {
                        CurrentX[x, y] = muisPositie.X - 50;
                        CurrentY[x, y] = muisPositie.Y - 50;
                        linksGeklikt[move] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if (((CurrentX[x, y] >= X_Locked[LockedX] && CurrentX[x, y] <= X_Locked[LockedX] + 20) && (CurrentY[x, y] <= Y_Locked[LockedY] && CurrentY[x, y] >= Y_Locked[LockedY] - 20)) || ((CurrentX[x, y] <= X_Locked[LockedX] && CurrentX[x, y] >= X_Locked[LockedX] - 20) && (CurrentY[x, y] <= Y_Locked[LockedY] && CurrentY[x, y] >= Y_Locked[LockedY] - 20)))
                        {
                            CurrentX[x, y] = X_Locked[LockedX];
                            CurrentY[x, y] = Y_Locked[LockedY];
                            Snap[move] = true;
                        }
                        if (((CurrentX[x, y] >= X_Locked[LockedX] && CurrentX[x, y] <= X_Locked[LockedX] + 20) && (CurrentY[x, y] >= Y_Locked[LockedY] && CurrentY[x, y] <= Y_Locked[LockedY] + 20)) || ((CurrentX[x, y] <= X_Locked[LockedX] && CurrentX[x, y] >= X_Locked[LockedX] - 20) && (CurrentY[x, y] >= Y_Locked[LockedY] && CurrentY[x, y] <= Y_Locked[LockedY] + 20)))
                        {
                            CurrentX[x, y] = X_Locked[LockedX];
                            CurrentY[x, y] = Y_Locked[LockedY];
                            Snap[move] = true;
                        }
                    }


                }


            }
            if (Snap[0] == true && Snap[1] == true && Snap[2] == true && Snap[3] == true && Snap[4] == true && Snap[5] == true && Snap[6] == true && Snap[7] == true && Snap[8] == true && Snap[9] == true && Snap[10] == true && Snap[11] == true && Snap[12] == true && Snap[13] == true && Snap[14] == true && Snap[15] == true && Snap[16] == true && Snap[17] == true && Snap[18] == true && Snap[19] == true && Snap[20] == true && Snap[21] == true && Snap[22] == true && Snap[23] == true && Snap[24] == true )
            {
                win = 1;
            }
        }
        public void Paint()
        {
            if (win == 0)
            {
                //m_GameEngine.SetColor(255, 215, 80);
                m_GameEngine.SetColor(0, 0, 0);
                m_GameEngine.SetColor(255, 215, 80);
                m_GameEngine.FillRectangle(699, 149, 502, 502);
                m_GameEngine.SetColor(0, 0, 0);
                m_GameEngine.DrawRectangle(699, 149, 502, 502);
                m_GameEngine.DrawString("room: Complete the puzzle to win.", 10, 10, 500, 10);
                m_GameEngine.DrawString("Left Mouse to select a piece.", 10, 30, 500, 10);
                m_GameEngine.DrawString("Right Mouse to place the piece.", 10, 50, 500, 10);

                //1,1
                m_GameEngine.DrawBitmap(Orb, CurrentX[0, 0], CurrentY[0, 0], 0, 0, 100, 100);
                //1,2
                m_GameEngine.DrawBitmap(Orb, CurrentX[0, 1], CurrentY[0, 1], 100, 0, 100, 100);
                //1,3
                m_GameEngine.DrawBitmap(Orb, CurrentX[0, 2], CurrentY[0, 2], 200, 0, 100, 100);
                //1,4
                m_GameEngine.DrawBitmap(Orb, CurrentX[0, 3], CurrentY[0, 3], 300, 0, 100, 100);
                //1,5
                m_GameEngine.DrawBitmap(Orb, CurrentX[0, 4], CurrentY[0, 4], 400, 0, 100, 100);
                //2,1
                m_GameEngine.DrawBitmap(Orb, CurrentX[1, 0], CurrentY[1, 0], 0, 100, 100, 100);
                //2,2
                m_GameEngine.DrawBitmap(Orb, CurrentX[1, 1], CurrentY[1, 1], 100, 100, 100, 100);
                //2,3
                m_GameEngine.DrawBitmap(Orb, CurrentX[1, 2], CurrentY[1, 2], 200, 100, 100, 100);
                //2,4
                m_GameEngine.DrawBitmap(Orb, CurrentX[1, 3], CurrentY[1, 3], 300, 100, 100, 100);
                //2,5
                m_GameEngine.DrawBitmap(Orb, CurrentX[1, 4], CurrentY[1, 4], 400, 100, 100, 100);
                //3,1
                m_GameEngine.DrawBitmap(Orb, CurrentX[2, 0], CurrentY[2, 0], 0, 200, 100, 100);
                //3,2
                m_GameEngine.DrawBitmap(Orb, CurrentX[2, 1], CurrentY[2, 1], 100, 200, 100, 100);
                //3,3
                m_GameEngine.DrawBitmap(Orb, CurrentX[2, 2], CurrentY[2, 2], 200, 200, 100, 100);
                //3,4
                m_GameEngine.DrawBitmap(Orb, CurrentX[2, 3], CurrentY[2, 3], 300, 200, 100, 100);
                //3,5
                m_GameEngine.DrawBitmap(Orb, CurrentX[2, 4], CurrentY[2, 4], 400, 200, 100, 100);
                //4,1
                m_GameEngine.DrawBitmap(Orb, CurrentX[3, 0], CurrentY[3, 0], 0, 300, 100, 100);
                //4,2
                m_GameEngine.DrawBitmap(Orb, CurrentX[3, 1], CurrentY[3, 1], 100, 300, 100, 100);
                //4,3
                m_GameEngine.DrawBitmap(Orb, CurrentX[3, 2], CurrentY[3, 2], 200, 300, 100, 100);
                //4,4
                m_GameEngine.DrawBitmap(Orb, CurrentX[3, 3], CurrentY[3, 3], 300, 300, 100, 100);
                //4,5
                m_GameEngine.DrawBitmap(Orb, CurrentX[3, 4], CurrentY[3, 4], 400, 300, 100, 100);
                //5,1
                m_GameEngine.DrawBitmap(Orb, CurrentX[4, 0], CurrentY[4, 0], 0, 400, 100, 100);
                //5,2
                m_GameEngine.DrawBitmap(Orb, CurrentX[4, 1], CurrentY[4, 1], 100, 400, 100, 100);
                //5,3
                m_GameEngine.DrawBitmap(Orb, CurrentX[4, 2], CurrentY[4, 2], 200, 400, 100, 100);
                //5,
                m_GameEngine.DrawBitmap(Orb, CurrentX[4, 3], CurrentY[4, 3], 300, 400, 100, 100);
                //5,5
                m_GameEngine.DrawBitmap(Orb, CurrentX[4, 4], CurrentY[4, 4], 400, 400, 100, 100);

                m_GameEngine.DrawBitmap(MiniOrb, 400, 10);
            }
            if (win == 1)
            {
                m_GameEngine.DrawString("YOU WON !!!!!!!!!!!!!!!!!!!!!!!!!!!!", 300, 10, 500, 10);
            }

            m_GameEngine.SetColor(139, 0, 0);
            m_GameEngine.FillRectangle(xPositie + 4, yPositie - 2, 10, 3);
            m_GameEngine.FillRectangle(xPositie, yPositie - 14, 3, 10);
            m_GameEngine.FillRectangle(xPositie - 12, yPositie - 2, 10, 3);
            m_GameEngine.FillRectangle(xPositie, yPositie + 3, 3, 10);
            m_GameEngine.SetColor(0, 0, 0);
        }
    }
}
