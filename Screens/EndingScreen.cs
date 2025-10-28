using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
using static Raylib_cs.KeyboardKey;
using static Raylib_cs.Gesture;
using Raylib_cs;

namespace RayLibCS.Screens
{
    internal class EndingScreen : GenericScreen
    {
        static int framesCounter = 0;
        static int finishScreen = 0;

        public override void DrawScreen()
        {
            // TODO: Draw ENDING screen here!
            DrawRectangle(0, 0, GetScreenWidth(), GetScreenHeight(), Blue);

            Vector2 pos = new Vector2(20, 10);
            DrawTextEx(font, "ENDING SCREEN", pos, font.BaseSize * 3.0f, 4, DarkBlue);
            DrawText("PRESS ENTER or TAP to RETURN to TITLE SCREEN", 120, 220, 20, DarkBlue);
        }

        public override int FinishScreen()
        {
            return finishScreen;
        }

        public override void InitScreen()
        {
            // TODO: Initialize ENDING screen variables here!
            framesCounter = 0;
            finishScreen = 0;
        }

        public override void UnloadScreen()
        {
            
        }

        public override void UpdateScreen()
        {
            // TODO: Update ENDING screen variables here!

            // Press enter or tap to return to TITLE screen
            if (Raylib.IsKeyPressed(KeyboardKey.Enter) || Raylib.IsGestureDetected(Gesture.Tap))    
            {
                finishScreen = 1;
                PlaySound(fxCoin);
            }
        }
    }
}
