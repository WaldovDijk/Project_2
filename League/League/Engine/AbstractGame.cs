using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{

    //Hides the basic setup from the League class.
    public class AbstractGame : GameObject
    {
        public int[] X_Locked = new int[5];
        public int[] Y_Locked = new int[5];

        
        //1,1
        public int CurrentX1_1 = 100;
        public int CurrentY1_1 = 100;
        //1,2
        public int CurrentX1_2 = 210;
        public int CurrentY1_2 = 210;
        //1,3
        public int CurrentX1_3 = 320;
        public int CurrentY1_3 = 320;
        //1,4
        public int CurrentX1_4 = 430;
        public int CurrentY1_4 = 430;
        //1,5
        public int CurrentX1_5 = 540;
        public int CurrentY1_5 = 540;
        //2,1
        public int CurrentX2_1 = 540;
        public int CurrentY2_1 = 100;
        //2,2
        public int CurrentX2_2 = 210;
        public int CurrentY2_2 = 540;
        //2,3
        public int CurrentX2_3 = 540;
        public int CurrentY2_3 = 320;
        //2,4
        public int CurrentX2_4 = 100;
        public int CurrentY2_4 = 430;
        //2,5
        public int CurrentX2_5 = 430;
        public int CurrentY2_5 = 210;
        //3,1
        public int CurrentX3_1 = 100;
        public int CurrentY3_1 = 210;
        //3,2
        public int CurrentX3_2 = 320;
        public int CurrentY3_2 = 540;
        //3,3
        public int CurrentX3_3 = 100;
        public int CurrentY3_3 = 320;
        //3,4
        public int CurrentX3_4 = 430;
        public int CurrentY3_4 = 320;
        //3,5
        public int CurrentX3_5 = 320;
        public int CurrentY3_5 = 100;
        //4,1
        public int CurrentX4_1 = 100;
        public int CurrentY4_1 = 540;
        //4,2
        public int CurrentX4_2 = 540;
        public int CurrentY4_2 = 430;
        //4,3
        public int CurrentX4_3 = 210;
        public int CurrentY4_3 = 100;
        //4,4
        public int CurrentX4_4 = 540;
        public int CurrentY4_4 = 210;
        //4,5
        public int CurrentX4_5 = 430;
        public int CurrentY4_5 = 540;
        //5,1
        public int CurrentX5_1 = 430;
        public int CurrentY5_1 = 100;
        //5,2
        public int CurrentX5_2 = 210;
        public int CurrentY5_2 = 430;
        //5,3
        public int CurrentX5_3 = 210;
        public int CurrentY5_3 = 320;
        //5,4
        public int CurrentX5_4 = 320;
        public int CurrentY5_4 = 210;
        //5,5
        public int CurrentX5_5 = 320;
        public int CurrentY5_5 = 430;
        
        //Int's
        public float p1_SpeedX;
        public float p1_SpeedY;
        public float p1_posX = 540;
        public float p1_posY = 440;
        public int xPositie;
        public int yPositie;
        public int room = 1;
        //Strings

        //Booleans
        public bool[] Snap = new bool[25];
        public bool[] linksGeklikt = new bool[25];
        public bool rechtsGeklikt;
        public bool W_move = false;
        public bool S_move = false;
        public bool A_move = false;
        public bool D_move = false;
        public bool Up_move = false;
        public bool Down_move = false;
        public bool Left_move = false;
        public bool Right_move = false;

        public override void GameInitialize()
        {
            // Set the required values
            GAME_ENGINE.SetTitle("League of Advanture");
            GAME_ENGINE.SetIcon("icon.ico");

            // Set the optional values
            GAME_ENGINE.SetWidth (1280);
            GAME_ENGINE.SetHeight(768);
            //GAME_ENGINE.SetBackgroundColor(0, 167, 141); //Appelblauwzeegroen
            GAME_ENGINE.SetBackgroundColor(49, 77, 121); //The Unity background color
        }
    }
}
