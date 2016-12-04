using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    class Movement
    {
        private Bitmap Achtergrond_2 = new Bitmap("Achtergrond_2.jpg");
        private Bitmap Achtergrond_3 = new Bitmap("Achtergrond_3.jpg");
        private Bitmap Achtergrond_4 = new Bitmap("Achtergrond_4.jpg");
        private Bitmap Achtergrond_7 = new Bitmap("Achtergrond_7.jpg");
        private Bitmap Achtergrond_8 = new Bitmap("Achtergrond_8.jpg");
        //private Bitmap Character = new Bitmap("")

        private Button Puzzeltje;

        private float p1_posX = 550;
        private float p1_posY = 450;
        private float xPositie;
        private float yPositie;
        private int room = 1;
        private int Puzzel = 0;
        private bool Right_move;
        private bool Left_move;
        private bool D_move;
        private bool A_move;
        private bool W_move;
        private bool Up_move;
        private bool Down_move;
        private bool S_move;

        GameEngine m_GameEngine;

        //Puzzle puzzle;
        Stuk stuk;
        public Movement()
        {
            stuk = new Stuk();
            m_GameEngine = GameEngine.GetInstance();
            Puzzeltje = new Button(StartClick, "This is a stupid puzzle", 1000, 340, 200, 100);
            Puzzeltje.SetActive(false);

        }
        public void StartClick()
        {
            Puzzel = 1;
            
        }
        public void Update()
        {
            Vector2 muisPositie = m_GameEngine.GetMousePosition();
            xPositie = muisPositie.X;
            yPositie = muisPositie.Y;
            if (Puzzel == 0)
            { 

            
                //player right
                if (m_GameEngine.GetKey(Key.D) && (p1_posY >= -1 || p1_posY <= 792))
                {
                    D_move = true;
                }
                else
                {
                    D_move = false;
                }
                if (m_GameEngine.GetKey(Key.Right) && (p1_posY >= -1 || p1_posY <= 792))
                {
                Right_move = true;
                }
                else
                {
                    Right_move = false;
                }
                //player left
                if (m_GameEngine.GetKey(Key.A) && (p1_posY >= -1 || p1_posY <= 792))
                {
                    A_move = true;
                }
                else
                {
                    A_move = false;
                }
                if (m_GameEngine.GetKey(Key.Left) && (p1_posY >= -1 || p1_posY <= 792))
                {
                    Left_move = true;
                }
                else
                {
                    Left_move = false;
                }
                //player up
                if (m_GameEngine.GetKey(Key.W) && (p1_posX >= 0 || p1_posX <= 1701))
                {
                    W_move = true;
                }
                else
                {
                    W_move = false;
                }
                if (m_GameEngine.GetKey(Key.Up) && (p1_posX >= 0 || p1_posX <= 1701))
                {
                    Up_move = true;
                }
                else
                {
                    Up_move = false;
                }
                //player down
                if (m_GameEngine.GetKey(Key.S) && (p1_posX <= 1647 || p1_posX <= 0))
                {
                    S_move = true;
                }
                else
                {
                    S_move = false;
                }
                if (m_GameEngine.GetKey(Key.Down) && (p1_posX <= 1647 || p1_posX <= 0))
                {
                    Down_move = true;
                }
                else
                {
                    Down_move = false;
                }
                //W, S, A and D movement
                if (W_move == true)
                {
                    p1_posY -= 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (Up_move == true)
                {
                    p1_posY -= 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (S_move == true)
                {
                    p1_posY += 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (Down_move == true)
                {
                    p1_posY += 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (A_move == true)
                {
                    p1_posX -= 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (Left_move == true)
                {
                    p1_posX -= 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (D_move == true)
                {
                    p1_posX += 400.0f * m_GameEngine.GetDeltaTime();
                }
                if (Right_move == true)
                {
                    p1_posX += 400.0f * m_GameEngine.GetDeltaTime();
                }

                //Room 2
                if (room == 1)
                {
                    Puzzeltje.SetActive(false);
                    if (p1_posX <= 0)
                {
                    p1_posX = 0;
                }
                if (p1_posX >= 1200)
                {
                    p1_posX = 1200;
                }
                if (p1_posY <= 0)
                {
                    p1_posY = 0;
                }
                if (p1_posY >= 538)
                {
                    p1_posY = 538;
                }
                if (p1_posY <= 370 && p1_posX <= 432)
                {
                    if (p1_posX >= 402)
                    {
                        p1_posX = 432;
                    }
                    else
                    {
                        p1_posY = 370;
                    }
                }
                if (p1_posY <= 370 && p1_posX >= 788)
                {
                    if (p1_posX <= 808)
                    {
                        p1_posX = 788;
                    }
                    else
                    {
                        p1_posY = 370;
                    }
                }
                if (p1_posY <= 280)
                {
                    room = 2;
                    p1_posY = 450;
                }
                if (p1_posX >= 1199)
                {
                    room = 6;
                    p1_posX = 20;
                }
                if (p1_posY >= 537)
                {
                    room = 1;
                    p1_posY = 450;
                }
            }
            //Room 3
            if (room == 2)
            {
                    Puzzeltje.SetActive(false);
                    if (p1_posX <= 0)
                {
                    p1_posX = 0;
                }
                if (p1_posX >= 1200)
                {
                    p1_posX = 1200;
                }
                if (p1_posY <= 0)
                {
                    p1_posY = 0;
                }
                if (p1_posY >= 538)
                {
                    p1_posY = 538;
                }
                if (p1_posY <= 450 && p1_posX <= 390)
                {
                    if (p1_posX >= 370)
                    {
                        p1_posX = 390;
                    }                   
                    else
                    {
                        p1_posY = 450;
                    }
                }
                if (p1_posY <= 450 && p1_posX >= 780)
                {
                    if (p1_posX <= 800)
                    {
                        p1_posX = 780;
                    }
                    else
                    {
                        p1_posY = 450;
                    }
                }
                if (p1_posY <= 210)
                {
                    room = 3;
                    p1_posY = 450;
                }
                if (p1_posY >= 537)
                {
                    room = 1;
                    p1_posY = 450;
                }
            }
            //Room 4
            if (room == 3)
            {
                Puzzeltje.SetActive(true);
                if (p1_posX <= 0)
                {
                    p1_posX = 0;
                }
                if (p1_posX >= 1200)
                {
                    p1_posX = 1200;
                }
                if (p1_posY <= 0)
                {
                    p1_posY = 0;
                }
                if (p1_posY >= 538)
                {
                    p1_posY = 538;
                }
                if (p1_posY <= 400 )
                {
                        p1_posY = 400;
                }
                if (p1_posY <= 400 )
                {
                        p1_posY = 400;                   
                }
                if (p1_posX <= 0)
                {
                    room = 3;
                    p1_posX = 0;
                }
                if (p1_posX >= 1200)
                {
                    room = 3;
                    p1_posX = 1200;
                }
                if (p1_posY >= 537)
                {
                    room = 2;
                    p1_posY = 450;
                }
            }
            //Room 5
            if (room == 4)
            {
                    Puzzeltje.SetActive(false);
                    if (p1_posX <= 0)
                {
                    p1_posX = 0;
                }
                if (p1_posX >= 1200)
                {
                    p1_posX = 1200;
                }
                if (p1_posY <= 0)
                {
                    p1_posY = 0;
                }
                if (p1_posY >= 538)
                {
                    p1_posY = 538;
                }
                if (p1_posY <= 400)
                {
                    p1_posY = 400;
                }
                if (p1_posY <= 400)
                {
                    p1_posY = 400;
                }
                if (p1_posX <= 0)
                {
                    room = 4;
                    p1_posX = 1200;
                }
                if (p1_posX >= 1200)
                {
                    room = 3;
                    p1_posX = 0;
                }
            }
            //Room 7
            if (room == 6)
            {
                    Puzzeltje.SetActive(false);
                    if (p1_posX <= 0)
                {
                    p1_posX = 0;
                }
                if (p1_posX >= 1200)
                {
                    p1_posX = 1200;
                }
                if (p1_posY <= 0)
                {
                    p1_posY = 0;
                }
                if (p1_posY >= 538)
                {
                    p1_posY = 538;
                }
                if (p1_posY <= 370 && p1_posX <= 432)
                {
                    if (p1_posX >= 402)
                    {
                        p1_posX = 432;
                    }
                    else
                    {
                        p1_posY = 370;
                    }
                }
                if (p1_posY <= 370 && p1_posX >= 788)
                {
                    if (p1_posX <= 808)
                    {
                        p1_posX = 788;
                    }
                    else
                    {
                        p1_posY = 370;
                    }
                }
                if (p1_posY <= 280)
                {
                    room = 7;
                    p1_posY = 450;
                }
                if (p1_posX <= 1)
                {
                    room = 1;
                    p1_posX = 1180;
                }
                if (p1_posY >= 537)
                {
                    room = 6;
                    p1_posY = 450;
                }
            }
                //Room 8
                if (room == 7)
                {
                    Puzzeltje.SetActive(false);
                    if (p1_posX <= 0)
                    {
                        p1_posX = 0;
                    }
                    if (p1_posX >= 1200)
                    {
                        p1_posX = 1200;
                    }
                    if (p1_posY <= 0)
                    {
                        p1_posY = 0;
                    }
                    if (p1_posY >= 538)
                    {
                        p1_posY = 538;
                    }
                    if (p1_posY <= 315)
                    {
                        p1_posY = 315;
                    }
                    if (p1_posX <= 0)
                    {
                        room = 7;
                        p1_posX = 1200;
                    }
                    if (p1_posX >= 1200)
                    {
                        room = 7;
                        p1_posX = 0;
                    }
                    if (p1_posY >= 537)
                    {
                        room = 6;
                        p1_posY = 450;
                    }
                }
            }
            if (Puzzel == 1)
            {
                stuk.Update(0, 0, 0, 0, 0 );
                stuk.Update(0, 1, 1, 0, 1);
                stuk.Update(0, 2, 2, 0, 2);
                stuk.Update(0, 3, 3, 0, 3);
                stuk.Update(0, 4, 4, 0, 4);
                stuk.Update(1, 0, 5, 1, 0);
                stuk.Update(1, 1, 6, 1, 1);
                stuk.Update(1, 2, 7, 1, 2 );
                stuk.Update(1, 3, 8, 1, 3);
                stuk.Update(1, 4, 9, 1, 4);
                stuk.Update(2, 0, 10, 2, 0);
                stuk.Update(2, 1, 11, 2, 1);
                stuk.Update(2, 2, 12, 2, 2);
                stuk.Update(2, 3, 13, 2, 3);
                stuk.Update(2, 4, 14, 2, 4);
                stuk.Update(3, 0, 15, 3, 0);
                stuk.Update(3, 1, 16, 3, 1);
                stuk.Update(3, 2, 17, 3, 2);
                stuk.Update(3, 3, 18, 3, 3);
                stuk.Update(3, 4, 19, 3, 4);
                stuk.Update(4, 0, 20, 3, 0);
                stuk.Update(4, 1, 21, 3, 1);
                stuk.Update(4, 2, 22, 3, 2);
                stuk.Update(4, 3, 23, 3, 3);
                stuk.Update(4, 4, 24, 3, 4);

                Puzzeltje.SetActive(false);
            }
        }
        public void Paint()
        {
            if (Puzzel == 0)
            {
                if (room == 0)
                {

                }
                if (room == 1)
                {
                    m_GameEngine.DrawBitmap(Achtergrond_2, 0, 0);

                }
                if (room == 2)
                {
                    m_GameEngine.DrawBitmap(Achtergrond_3, 0, 0);


                }
                if (room == 3)
                {
                    m_GameEngine.DrawBitmap(Achtergrond_4, 0, 0);
                }
                if (room == 4)
                {

                }
                if (room == 5)
                {

                }
                if (room == 6)
                {
                    m_GameEngine.DrawBitmap(Achtergrond_7, 0, 0);
                }
                if (room == 7)
                {
                    m_GameEngine.DrawBitmap(Achtergrond_8, 0, 0);
                }
                if (room == 8)
                {

                }
                if (room == 9)
                {

                }
                if (room == 10)
                {

                }
                if (room == 11)
                {

                }
                if (room == 12)
                {

                }
                if (room == 13)
                {

                }
                if (room == 14)
                {

                }
                if (room == 15)
                {

                }
                m_GameEngine.FillRectangle(p1_posX, p1_posY, 80, 230);
                m_GameEngine.DrawString("" + p1_posX + ".", 10, 10, 200, 10);
                m_GameEngine.DrawString("" + p1_posY + ".", 10, 30, 200, 10);
                m_GameEngine.DrawString("" + room + ".", 10, 50, 200, 10);

                m_GameEngine.SetColor(139, 0, 0);
                m_GameEngine.FillRectangle(xPositie + 4, yPositie - 2, 10, 3);
                m_GameEngine.FillRectangle(xPositie, yPositie - 14, 3, 10);
                m_GameEngine.FillRectangle(xPositie - 12, yPositie - 2, 10, 3);
                m_GameEngine.FillRectangle(xPositie, yPositie + 3, 3, 10);
                m_GameEngine.SetColor(0, 0, 0);

            }
            if (Puzzel == 1)
            {
                stuk.Paint();
            }
        }
    }
}