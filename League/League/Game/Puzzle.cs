using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Puzzle : AbstractGame
    {
        private int i;
        private bool[] m_Een = new bool[25];
        private Bitmap Orb = new Bitmap("Orb.png");
        public override void GameStart()
        {
            
            //Row 1 X
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
        public override void Update()
        {
            
            Vector2 muisPositie = GAME_ENGINE.GetMousePosition();
            xPositie = muisPositie.X;
            yPositie = muisPositie.Y;

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
                    for (i = 0; i < 25; i++)
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
                        for (i = 0; i < 25; i++)
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
            //1,2
            if (Snap[1] == false && m_Een[1] == false)
            {
                if ((xPositie >= CurrentX1_2 && xPositie <= CurrentX1_2 + 101) && (yPositie >= CurrentY1_2 && yPositie <= CurrentY1_2 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[1] == false)
                    {
                        linksGeklikt[1] = true;
                    }
                }
                if (linksGeklikt[1] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[1] = false;
                    }
                    CurrentX1_2 = xPositie - 50;
                    CurrentY1_2 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX1_2 = muisPositie.X - 50;
                        CurrentY1_2 = muisPositie.Y - 50;
                        linksGeklikt[1] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX1_2 >= X_Locked[1] && CurrentX1_2 <= X_Locked[1] + 40) && (CurrentY1_2 >= Y_Locked[0] && CurrentY1_2 <= Y_Locked[0] + 40))
                        {
                            CurrentX1_2 = X_Locked[1];
                            CurrentY1_2 = Y_Locked[0];
                            Snap[1] = true;
                        }
                    }
                }
            }
            //1,3
            if (Snap[2] == false && m_Een[2] == false)
            {
                if ((xPositie >= CurrentX1_3 && xPositie <= CurrentX1_3 + 101) && (yPositie >= CurrentY1_3 && yPositie <= CurrentY1_3 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[2] == false)
                    {
                        linksGeklikt[2] = true;
                    }
                }
                if (linksGeklikt[2] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[2] = false;
                    }
                    CurrentX1_3 = xPositie - 50;
                    CurrentY1_3 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX1_3 = muisPositie.X - 50;
                        CurrentY1_3 = muisPositie.Y - 50;
                        linksGeklikt[2] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX1_3 >= X_Locked[2] && CurrentX1_3 <= X_Locked[2] + 40) && (CurrentY1_3 >= Y_Locked[0] && CurrentY1_3 <= Y_Locked[0] + 40))
                        {
                            CurrentX1_3 = X_Locked[2];
                            CurrentY1_3 = Y_Locked[0];
                            Snap[2] = true;
                        }
                    }
                }
            }
            //1,4
            if (Snap[3] == false && m_Een[3] == false)
            {
                if ((xPositie >= CurrentX1_4 && xPositie <= CurrentX1_4 + 101) && (yPositie >= CurrentY1_4 && yPositie <= CurrentY1_4 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[3] == false)
                    {
                        linksGeklikt[3] = true;
                    }
                }
                if (linksGeklikt[3] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[3] = false;
                    }
                    CurrentX1_4 = xPositie - 50;
                    CurrentY1_4 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX1_4 = muisPositie.X - 50;
                        CurrentY1_4 = muisPositie.Y - 50;
                        linksGeklikt[3] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX1_4 >= X_Locked[3] && CurrentX1_4 <= X_Locked[3] + 40) && (CurrentY1_4 >= Y_Locked[0] && CurrentY1_4 <= Y_Locked[0] + 40))
                        {
                            CurrentX1_4 = X_Locked[3];
                            CurrentY1_4 = Y_Locked[0];
                            Snap[3] = true;
                        }
                    }
                }
            }
            //1,5
            if (Snap[4] == false && m_Een[4] == false)
            {
                if ((xPositie >= CurrentX1_5 && xPositie <= CurrentX1_5 + 101) && (yPositie >= CurrentY1_5 && yPositie <= CurrentY1_5 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[4] == false)
                    {
                        linksGeklikt[4] = true;
                    }
                }
                if (linksGeklikt[4] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[4] = false;
                    }
                    CurrentX1_5 = xPositie - 50;
                    CurrentY1_5 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX1_5 = muisPositie.X - 50;
                        CurrentY1_5 = muisPositie.Y - 50;
                        linksGeklikt[4] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX1_5 >= X_Locked[4] && CurrentX1_5 <= X_Locked[4] + 40) && (CurrentY1_5 >= Y_Locked[0] && CurrentY1_5 <= Y_Locked[0] + 40))
                        {
                            CurrentX1_5 = X_Locked[4];
                            CurrentY1_5 = Y_Locked[0];
                            Snap[4] = true;
                        }
                    }
                }
            }
            //2,1
            if (Snap[5] == false && m_Een[5] == false)
            {
                if ((xPositie >= CurrentX2_1 && xPositie <= CurrentX2_1 + 101) && (yPositie >= CurrentY2_1 && yPositie <= CurrentY2_1 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[5] == false)
                    {
                        linksGeklikt[5] = true;
                    }
                }
                if (linksGeklikt[5] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[5] = false;
                    }
                    CurrentX2_1 = xPositie - 50;
                    CurrentY2_1 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX2_1 = muisPositie.X - 50;
                        CurrentY2_1 = muisPositie.Y - 50;
                        linksGeklikt[5] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX2_1 >= X_Locked[0] && CurrentX2_1 <= X_Locked[0] + 40) && (CurrentY2_1 >= Y_Locked[1] && CurrentY2_1 <= Y_Locked[1] + 40))
                        {
                            CurrentX2_1 = X_Locked[0];
                            CurrentY2_1 = Y_Locked[1];
                            Snap[5] = true;
                        }
                    }
                }
            }
            if (Snap[6] == false && m_Een[6] == false)
            {
                //2,2
                if ((xPositie >= CurrentX2_2 && xPositie <= CurrentX2_2 + 101) && (yPositie >= CurrentY2_2 && yPositie <= CurrentY2_2 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[6] == false)
                    {
                        linksGeklikt[6] = true;
                    }
                }
                if (linksGeklikt[6] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[6] = false;
                    }
                    CurrentX2_2 = xPositie - 50;
                    CurrentY2_2 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX2_2 = muisPositie.X - 50;
                        CurrentY2_2 = muisPositie.Y - 50;
                        linksGeklikt[6] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX2_2 >= X_Locked[1] && CurrentX2_2 <= X_Locked[1] + 40) && (CurrentY2_2 >= Y_Locked[1] && CurrentY2_2 <= Y_Locked[1] + 40))
                        {
                            CurrentX2_2 = X_Locked[1];
                            CurrentY2_2 = Y_Locked[1];
                            Snap[6] = true;
                        }
                    }
                }
            }
            //2,3 
            if (Snap[7] == false && m_Een[7] == false)
            {
                if ((xPositie >= CurrentX2_3 && xPositie <= CurrentX2_3 + 101) && (yPositie >= CurrentY2_3 && yPositie <= CurrentY2_3 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[7] == false)
                    {
                        linksGeklikt[7] = true;
                    }
                }
                if (linksGeklikt[7] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[7] = false;
                    }
                    CurrentX2_3 = xPositie - 50;
                    CurrentY2_3 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX2_3 = muisPositie.X - 50;
                        CurrentY2_3 = muisPositie.Y - 50;
                        linksGeklikt[7] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX2_3 >= X_Locked[2] && CurrentX2_3 <= X_Locked[2] + 40) && (CurrentY2_3 >= Y_Locked[1] && CurrentY2_3 <= Y_Locked[1] + 40))
                        {
                            CurrentX2_3 = X_Locked[2];
                            CurrentY2_3 = Y_Locked[1];
                            Snap[7] = true;
                        }
                    }
                }
            }
            //2,4
            if (Snap[8] == false && m_Een[8] == false)
            {
                if ((xPositie >= CurrentX2_4 && xPositie <= CurrentX2_4 + 101) && (yPositie >= CurrentY2_4 && yPositie <= CurrentY2_4 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[8] == false)
                    {
                        linksGeklikt[8] = true;
                    }
                }
                if (linksGeklikt[8] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[8] = false;
                    }
                    CurrentX2_4 = xPositie - 50;
                    CurrentY2_4 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX2_4 = muisPositie.X - 50;
                        CurrentY2_4 = muisPositie.Y - 50;
                        linksGeklikt[8] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX2_4 >= X_Locked[3] && CurrentX2_4 <= X_Locked[3] + 40) && (CurrentY2_4 >= Y_Locked[1] && CurrentY2_4 <= Y_Locked[1] + 40))
                        {
                            CurrentX2_4 = X_Locked[3];
                            CurrentY2_4 = Y_Locked[1];
                            Snap[8] = true;
                        }
                    }
                }
            }
            //2,5
            if (Snap[9] == false && m_Een[9] == false)
            {
                if ((xPositie >= CurrentX2_5 && xPositie <= CurrentX2_5 + 101) && (yPositie >= CurrentY2_5 && yPositie <= CurrentY2_5 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[9] == false)
                    {
                        linksGeklikt[9] = true;
                    }
                }
                if (linksGeklikt[9] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[9] = false;
                    }
                    CurrentX2_5 = xPositie - 50;
                    CurrentY2_5 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX2_5 = muisPositie.X - 50;
                        CurrentY2_5 = muisPositie.Y - 50;
                        linksGeklikt[9] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX2_5 >= X_Locked[4] && CurrentX2_5 <= X_Locked[4] + 40) && (CurrentY2_5 >= Y_Locked[1] && CurrentY2_5 <= Y_Locked[1] + 40))
                        {
                            CurrentX2_5 = X_Locked[4];
                            CurrentY2_5 = Y_Locked[1];
                            Snap[9] = true;
                        }
                    }
                }
            }
            //3,1
            if (Snap[10] == false && m_Een[10] == false)
            {
                if ((xPositie >= CurrentX3_1 && xPositie <= CurrentX3_1 + 101) && (yPositie >= CurrentY3_1 && yPositie <= CurrentY3_1 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[10] == false)
                    {
                        linksGeklikt[10] = true;
                    }
                }
                if (linksGeklikt[10] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[10] = false;
                    }
                    CurrentX3_1 = xPositie - 50;
                    CurrentY3_1 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX3_1 = muisPositie.X - 50;
                        CurrentY3_1 = muisPositie.Y - 50;
                        linksGeklikt[10] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX3_1 >= X_Locked[0] && CurrentX3_1 <= X_Locked[0] + 40) && (CurrentY3_1 >= Y_Locked[2] && CurrentY3_1 <= Y_Locked[2] + 40))
                        {
                            CurrentX3_1 = X_Locked[0];
                            CurrentY3_1 = Y_Locked[2];
                            Snap[10] = true;
                        }
                    }
                }
            }
            //3,2
            if (Snap[11] == false && m_Een[11] == false)
            {
                if ((xPositie >= CurrentX3_2 && xPositie <= CurrentX3_2 + 101) && (yPositie >= CurrentY3_2 && yPositie <= CurrentY3_2 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[11] == false)
                    {
                        linksGeklikt[11] = true;
                    }
                }
                if (linksGeklikt[11] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[11] = false;
                    }
                    CurrentX3_2 = xPositie - 50;
                    CurrentY3_2 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX3_2 = muisPositie.X - 50;
                        CurrentY3_2 = muisPositie.Y - 50;
                        linksGeklikt[11] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX3_2 >= X_Locked[1] && CurrentX3_2 <= X_Locked[1] + 40) && (CurrentY3_2 >= Y_Locked[2] && CurrentY3_2 <= Y_Locked[2] + 40))
                        {
                            CurrentX3_2 = X_Locked[1];
                            CurrentY3_2 = Y_Locked[2];
                            Snap[11] = true;
                        }
                    }
                }
            }
            //3,3
            if (Snap[12] == false && m_Een[12] == false)
            {
                if ((xPositie >= CurrentX3_3 && xPositie <= CurrentX3_3 + 101) && (yPositie >= CurrentY3_3 && yPositie <= CurrentY3_3 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[12] == false)
                    {
                        linksGeklikt[12] = true;
                    }
                }
                if (linksGeklikt[12] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[12] = false;
                    }
                    CurrentX3_3 = xPositie - 50;
                    CurrentY3_3 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX3_3 = muisPositie.X - 50;
                        CurrentY3_3 = muisPositie.Y - 50;
                        linksGeklikt[12] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX3_3 >= X_Locked[2] && CurrentX3_3 <= X_Locked[2] + 40) && (CurrentY3_3 >= Y_Locked[2] && CurrentY3_3 <= Y_Locked[2] + 40))
                        {
                            CurrentX3_3 = X_Locked[2];
                            CurrentY3_3 = Y_Locked[2];
                            Snap[12] = true;
                        }
                    }
                }
            }
            //3,4
            if (Snap[13] == false && m_Een[13] == false)
            {
                if ((xPositie >= CurrentX3_4 && xPositie <= CurrentX3_4 + 101) && (yPositie >= CurrentY3_4 && yPositie <= CurrentY3_4 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[13] == false)
                    {
                        linksGeklikt[13] = true;
                    }
                }
                if (linksGeklikt[13] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[13] = false;
                    }
                    CurrentX3_4 = xPositie - 50;
                    CurrentY3_4 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX3_4 = muisPositie.X - 50;
                        CurrentY3_4 = muisPositie.Y - 50;
                        linksGeklikt[13] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX3_4 >= X_Locked[3] && CurrentX3_4 <= X_Locked[3] + 40) && (CurrentY3_4 >= Y_Locked[2] && CurrentY3_4 <= Y_Locked[2] + 40))
                        {
                            CurrentX3_4 = X_Locked[3];
                            CurrentY3_4 = Y_Locked[2];
                            Snap[13] = true;
                        }
                    }
                }
            }
            //3,5
            if (Snap[14] == false && m_Een[14] == false)
            {
                if ((xPositie >= CurrentX3_5 && xPositie <= CurrentX3_5 + 101) && (yPositie >= CurrentY3_5 && yPositie <= CurrentY3_5 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[14] == false)
                    {
                        linksGeklikt[14] = true;
                    }
                }
                if (linksGeklikt[14] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[14] = false;
                    }
                    CurrentX3_5 = xPositie - 50;
                    CurrentY3_5 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX3_5 = muisPositie.X - 50;
                        CurrentY3_5 = muisPositie.Y - 50;
                        linksGeklikt[14] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX3_5 >= X_Locked[4] && CurrentX3_5 <= X_Locked[4] + 40) && (CurrentY3_5 >= Y_Locked[2] && CurrentY3_5 <= Y_Locked[2] + 40))
                        {
                            CurrentX3_5 = X_Locked[4];
                            CurrentY3_5 = Y_Locked[2];
                            Snap[14] = true;
                        }
                    }
                }
            }
            //4,1
            if (Snap[15] == false && m_Een[15] == false)
            {
                if ((xPositie >= CurrentX4_1 && xPositie <= CurrentX4_1 + 101) && (yPositie >= CurrentY4_1 && yPositie <= CurrentY4_1 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[15] == false)
                    {
                        linksGeklikt[15] = true;
                    }
                }
                if (linksGeklikt[15] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[15] = false;
                    }
                    CurrentX4_1 = xPositie - 50;
                    CurrentY4_1 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX4_1 = muisPositie.X - 50;
                        CurrentY4_1 = muisPositie.Y - 50;
                        linksGeklikt[15] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX4_1 >= X_Locked[0] && CurrentX4_1 <= X_Locked[0] + 40) && (CurrentY4_1 >= Y_Locked[3] && CurrentY4_1 <= Y_Locked[3] + 40))
                        {
                            CurrentX4_1 = X_Locked[0];
                            CurrentY4_1 = Y_Locked[3];
                            Snap[15] = true;
                        }
                    }
                }
            }
            //4,2
            if (Snap[16] == false && m_Een[16] == false)
            {
                if ((xPositie >= CurrentX4_2 && xPositie <= CurrentX4_2 + 101) && (yPositie >= CurrentY4_2 && yPositie <= CurrentY4_2 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[16] == false)
                    {
                        linksGeklikt[16] = true;
                    }
                }
                if (linksGeklikt[16] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[16] = false;
                    }
                    CurrentX4_2 = xPositie - 50;
                    CurrentY4_2 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX4_2 = muisPositie.X - 50;
                        CurrentY4_2 = muisPositie.Y - 50;
                        linksGeklikt[16] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX4_2 >= X_Locked[1] && CurrentX4_2 <= X_Locked[1] + 40) && (CurrentY4_2 >= Y_Locked[3] && CurrentY4_2 <= Y_Locked[3] + 40))
                        {
                            CurrentX4_2 = X_Locked[1];
                            CurrentY4_2 = Y_Locked[3];
                            Snap[16] = true;
                        }
                    }
                }
            }
            //4,3 
            if (Snap[17] == false && m_Een[17] == false)
            {
                if ((xPositie >= CurrentX4_3 && xPositie <= CurrentX4_3 + 101) && (yPositie >= CurrentY4_3 && yPositie <= CurrentY4_3 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[17] == false)
                    {
                        linksGeklikt[17] = true;
                    }
                }
                if (linksGeklikt[17] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[17] = false;
                    }
                    CurrentX4_3 = xPositie - 50;
                    CurrentY4_3 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX4_3 = muisPositie.X - 50;
                        CurrentY4_3 = muisPositie.Y - 50;
                        linksGeklikt[17] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX4_3 >= X_Locked[2] && CurrentX4_3 <= X_Locked[2] + 40) && (CurrentY4_3 >= Y_Locked[3] && CurrentY4_3 <= Y_Locked[3] + 40))
                        {
                            CurrentX4_3 = X_Locked[2];
                            CurrentY4_3 = Y_Locked[3];
                            Snap[17] = true;
                        }
                    }
                }
            }
            //4,4
            if (Snap[18] == false && m_Een[18] == false)
            {
                if ((xPositie >= CurrentX4_4 && xPositie <= CurrentX4_4 + 101) && (yPositie >= CurrentY4_4 && yPositie <= CurrentY4_4 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[18] == false)
                    {
                        linksGeklikt[18] = true;
                    }
                }
                if (linksGeklikt[18] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[18] = false;
                    }
                    CurrentX4_4 = xPositie - 50;
                    CurrentY4_4 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX4_4 = muisPositie.X - 50;
                        CurrentY4_4 = muisPositie.Y - 50;
                        linksGeklikt[18] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX4_4 >= X_Locked[3] && CurrentX4_4 <= X_Locked[3] + 40) && (CurrentY4_4 >= Y_Locked[3] && CurrentY4_4 <= Y_Locked[3] + 40))
                        {
                            CurrentX4_4 = X_Locked[3];
                            CurrentY4_4 = Y_Locked[3];
                            Snap[18] = true;
                        }
                    }
                }
            }
            //4,5
            if (Snap[19] == false && m_Een[19] == false)
            {
                if ((xPositie >= CurrentX4_5 && xPositie <= CurrentX4_5 + 101) && (yPositie >= CurrentY4_5 && yPositie <= CurrentY4_5 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[19] == false)
                    {
                        linksGeklikt[19] = true;
                    }
                }
                if (linksGeklikt[19] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[19] = false;
                    }
                    CurrentX4_5 = xPositie - 50;
                    CurrentY4_5 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX4_5 = muisPositie.X - 50;
                        CurrentY4_5 = muisPositie.Y - 50;
                        linksGeklikt[19] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX4_5 >= X_Locked[4] && CurrentX4_5 <= X_Locked[4] + 40) && (CurrentY4_5 >= Y_Locked[3] && CurrentY4_5 <= Y_Locked[3] + 40))
                        {
                            CurrentX4_5 = X_Locked[4];
                            CurrentY4_5 = Y_Locked[3];
                            Snap[19] = true;
                        }
                    }
                }
            }
            //5,1
            if (Snap[20] == false && m_Een[20] == false)
            {
                if ((xPositie >= CurrentX5_1 && xPositie <= CurrentX5_1 + 101) && (yPositie >= CurrentY5_1 && yPositie <= CurrentY5_1 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[20] == false)
                    {
                        linksGeklikt[20] = true;
                    }
                }
                if (linksGeklikt[20] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[20] = false;
                    }
                    CurrentX5_1 = xPositie - 50;
                    CurrentY5_1 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX5_1 = muisPositie.X - 50;
                        CurrentY5_1 = muisPositie.Y - 50;
                        linksGeklikt[20] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX5_1 >= X_Locked[0] && CurrentX5_1 <= X_Locked[0] + 40) && (CurrentY5_1 >= Y_Locked[4] && CurrentY5_1 <= Y_Locked[4] + 40))
                        {
                            CurrentX5_1 = X_Locked[0];
                            CurrentY5_1 = Y_Locked[4];
                            Snap[20] = true;
                        }
                    }
                }
            }
            //5,2
            if (Snap[21] == false && m_Een[21] == false)
            {
                if ((xPositie >= CurrentX5_2 && xPositie <= CurrentX5_2 + 101) && (yPositie >= CurrentY5_2 && yPositie <= CurrentY5_2 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[21] == false)
                    {
                        linksGeklikt[21] = true;
                    }
                }
                if (linksGeklikt[21] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[21] = false;
                    }
                    CurrentX5_2 = xPositie - 50;
                    CurrentY5_2 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX5_2 = muisPositie.X - 50;
                        CurrentY5_2 = muisPositie.Y - 50;
                        linksGeklikt[21] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX5_2 >= X_Locked[1] && CurrentX5_2 <= X_Locked[1] + 40) && (CurrentY5_2 >= Y_Locked[4] && CurrentY5_2 <= Y_Locked[4] + 40))
                        {
                            CurrentX5_2 = X_Locked[1];
                            CurrentY5_2 = Y_Locked[4];
                            Snap[21] = true;
                        }
                    }
                }
            }
            //5,3
            if (Snap[22] == false && m_Een[22] == false)
            {
                if ((xPositie >= CurrentX5_3 && xPositie <= CurrentX5_3 + 101) && (yPositie >= CurrentY5_3 && yPositie <= CurrentY5_3 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[22] == false)
                    {
                        linksGeklikt[22] = true;
                    }
                }
                if (linksGeklikt[22] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[22] = false;
                    }
                    CurrentX5_3 = xPositie - 50;
                    CurrentY5_3 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX5_3 = muisPositie.X - 50;
                        CurrentY5_3 = muisPositie.Y - 50;
                        linksGeklikt[22] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX5_3 >= X_Locked[2] && CurrentX5_3 <= X_Locked[2] + 40) && (CurrentY5_3 >= Y_Locked[4] && CurrentY5_3 <= Y_Locked[4] + 40))
                        {
                            CurrentX5_3 = X_Locked[2];
                            CurrentY5_3 = Y_Locked[4];
                            Snap[22] = true;
                        }
                    }
                }
            }
            //5,4
            if (Snap[23] == false && m_Een[23] == false)
            {
                if ((xPositie >= CurrentX5_4 && xPositie <= CurrentX5_4 + 101) && (yPositie >= CurrentY5_4 && yPositie <= CurrentY5_4 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[23] == false)
                    {
                        linksGeklikt[23] = true;
                    }
                }
                if (linksGeklikt[23] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[23] = false;
                    }
                    CurrentX5_4 = xPositie - 50;
                    CurrentY5_4 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX5_4 = muisPositie.X - 50;
                        CurrentY5_4 = muisPositie.Y - 50;
                        linksGeklikt[23] = false;
                        for (i = 0; i < 25; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX5_4 >= X_Locked[3] && CurrentX5_4 <= X_Locked[3] + 40) && (CurrentY5_4 >= Y_Locked[4] && CurrentY5_4 <= Y_Locked[4] + 40))
                        {
                            CurrentX5_4 = X_Locked[3];
                            CurrentY5_4 = Y_Locked[4];
                            Snap[23] = true;
                        }
                    }
                }
            }
            //5,5
            if (Snap[24] == false && m_Een[24] == false)
            {
                if ((xPositie >= CurrentX5_5 && xPositie <= CurrentX5_5 + 101) && (yPositie >= CurrentY5_5 && yPositie <= CurrentY5_5 + 101))
                {
                    if (GAME_ENGINE.GetMouseButtonUp(0) && linksGeklikt[24] == false)
                    {
                        linksGeklikt[24] = true;
                    }
                }
                if (linksGeklikt[24] == true)
                {
                    for (i = 0; i < 25; i++)
                    {
                        m_Een[i] = true;
                        m_Een[24] = false;
                    }
                    CurrentX5_5 = xPositie - 50;
                    CurrentY5_5 = yPositie - 50;
                    if (GAME_ENGINE.GetMouseButtonUp(1))
                    {
                        CurrentX5_5 = muisPositie.X - 50;
                        CurrentY5_5 = muisPositie.Y - 50;
                        linksGeklikt[24] = false;
                        for (i = 0; i < 24; i++)
                        {
                            m_Een[i] = false;
                        }
                        if ((CurrentX5_5 >= X_Locked[4] && CurrentX5_5 <= X_Locked[4] + 40) && (CurrentY5_5 >= Y_Locked[4] && CurrentY5_5 <= Y_Locked[4] + 40))
                        {
                            CurrentX5_5 = X_Locked[4];
                            CurrentY5_5 = Y_Locked[4];
                            Snap[24] = true;
                        }
                    }
                }
            }
            
        }
        public override void Paint()
        {
            
            GAME_ENGINE.SetColor(0, 0, 0);      
            GAME_ENGINE.SetColor(255, 215, 80);
            GAME_ENGINE.FillRectangle(700, 150, 501, 501);
            GAME_ENGINE.SetColor(0, 0, 0);
            GAME_ENGINE.DrawRectangle(700, 150, 502, 502);
            //1,1
            GAME_ENGINE.DrawBitmap(Orb, CurrentX1_1, CurrentY1_1, 0, 0, 100, 100);
            //1,2
            GAME_ENGINE.DrawBitmap(Orb, CurrentX1_2, CurrentY1_2, 100, 0, 100, 100);
            //1,3
            GAME_ENGINE.DrawBitmap(Orb, CurrentX1_3, CurrentY1_3, 200, 0, 100, 100);
            //1,4
            GAME_ENGINE.DrawBitmap(Orb, CurrentX1_4, CurrentY1_4, 300, 0, 100, 100);
            //1,5
            GAME_ENGINE.DrawBitmap(Orb, CurrentX1_5, CurrentY1_5, 400, 0, 100, 100);
            //2,1
            GAME_ENGINE.DrawBitmap(Orb, CurrentX2_1, CurrentY2_1, 0, 100, 100, 100);
            //2,2
            GAME_ENGINE.DrawBitmap(Orb, CurrentX2_2, CurrentY2_2, 100, 100, 100, 100);
            //2,3
            GAME_ENGINE.DrawBitmap(Orb, CurrentX2_3, CurrentY2_3, 200, 100, 100, 100);
            //2,4
            GAME_ENGINE.DrawBitmap(Orb, CurrentX2_4, CurrentY2_4, 300, 100, 100, 100);
            //2,5
            GAME_ENGINE.DrawBitmap(Orb, CurrentX2_5, CurrentY2_5, 400, 100, 100, 100);
            //3,1
            GAME_ENGINE.DrawBitmap(Orb, CurrentX3_1, CurrentY3_1, 0, 200, 100, 100);
            //3,2
            GAME_ENGINE.DrawBitmap(Orb, CurrentX3_2, CurrentY3_2, 100, 200, 100, 100);
            //3,3
            GAME_ENGINE.DrawBitmap(Orb, CurrentX3_3, CurrentY3_3, 200, 200, 100, 100);
            //3,4
            GAME_ENGINE.DrawBitmap(Orb, CurrentX3_4, CurrentY3_4, 300, 200, 100, 100);
            //3,5
            GAME_ENGINE.DrawBitmap(Orb, CurrentX3_5, CurrentY3_5, 400, 200, 100, 100);
            //4,1
            GAME_ENGINE.DrawBitmap(Orb, CurrentX4_1, CurrentY4_1, 0, 300, 100, 100);
            //4,2
            GAME_ENGINE.DrawBitmap(Orb, CurrentX4_2, CurrentY4_2, 100, 300, 100, 100);
            //4,3
            GAME_ENGINE.DrawBitmap(Orb, CurrentX4_3, CurrentY4_3, 200, 300, 100, 100);
            //4,4
            GAME_ENGINE.DrawBitmap(Orb, CurrentX4_4, CurrentY4_4, 300, 300, 100, 100);
            //4,5
            GAME_ENGINE.DrawBitmap(Orb, CurrentX4_5, CurrentY4_5, 400, 300, 100, 100);
            //5,1
            GAME_ENGINE.DrawBitmap(Orb, CurrentX5_1, CurrentY5_1, 0, 400, 100, 100);
            //5,2
            GAME_ENGINE.DrawBitmap(Orb, CurrentX5_2, CurrentY5_2, 100, 400, 100, 100);
            //5,3
            GAME_ENGINE.DrawBitmap(Orb, CurrentX5_3, CurrentY5_3, 200, 400, 100, 100);
            //5,4
            GAME_ENGINE.DrawBitmap(Orb, CurrentX5_4, CurrentY5_4, 300, 400, 100, 100);
            //5,5
            GAME_ENGINE.DrawBitmap(Orb, CurrentX5_5, CurrentY5_5, 400, 400, 100, 100);

            /*
            GAME_ENGINE.SetColor(139, 0, 0);
            GAME_ENGINE.DrawLine(xPositie + 2, yPositie, xPositie + 10, yPositie);
            GAME_ENGINE.DrawLine(xPositie, yPositie + 2, xPositie, yPositie + 10);
            GAME_ENGINE.DrawLine(xPositie - 2, yPositie, xPositie - 10, yPositie);
            GAME_ENGINE.DrawLine(xPositie, yPositie - 2, xPositie, yPositie - 10);
            GAME_ENGINE.SetColor(0, 0, 0);
            */
        }
    }
}