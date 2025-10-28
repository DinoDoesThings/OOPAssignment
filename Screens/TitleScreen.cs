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
    internal class TitleScreen : GenericScreen
    {

        static int framesCounter = 0;
        static int finishScreen = 0;

        public override void DrawScreen()
        {
            // TODO: Draw TITLE screen here!
            DrawRectangle(0, 0, GetScreenWidth(), GetScreenHeight(), Green);
            Vector2 pos = new Vector2( 20, 10 );
            DrawTextEx(font, "TITLE SCREEN", pos, font.BaseSize * 3.0f, 4, DarkGreen);
            DrawText("PRESS ENTER or TAP to JUMP to GAMEPLAY SCREEN", 120, 220, 20, DarkGreen);
        }

        public override int FinishScreen()
        {
            return finishScreen;
        }

        public override void InitScreen()
        {
            framesCounter = 0;
            finishScreen = 0;
        }

        public override void UnloadScreen()
        {

        }

        public override void UpdateScreen()
        {
            // Press enter or tap to change to GAMEPLAY screen
            if (Raylib.IsKeyPressed(KeyboardKey.Enter) || Raylib.IsGestureDetected(Gesture.Tap))
            {
                //finishScreen = 1;   // OPTIONS
                finishScreen = 2;   // GAMEPLAY
                PlaySound(fxCoin);
            }
        }
    }
}
