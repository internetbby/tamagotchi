using System;
using System.Collections.Generic;
using Raylib_cs;

namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Tamagotchi"); //Initilization 

            string currentScreen = "title"; //adding a sort of function to switch screens

            List<string> tamagotchi = new List<string>();


            Raylib.SetTargetFPS(60);
            Tamagotchi t1 = null;




            while (!Raylib.WindowShouldClose())
            { //Main game loop

                List<string> tamagotchisOWned = new List<string>();

                switch (currentScreen)
                { //Game logic
                    case "title":

                        if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                        {
                            if (tamagotchisOWned.Count < 1)
                            {
                                currentScreen = "createAPet";
                                t1 = new Tamagotchi();

                            }
                            else
                            {
                                currentScreen = "petOwned";
                            }
                        }

                        break;

                    case "createAPet":
                        if(Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
                            currentScreen ="petScreen";
                       
                        }



                        break;


                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                switch (currentScreen)
                { //Drawing on that screen
                    case "title":
                        //Draw title

                        Raylib.DrawText("PRESS ENTER TO BEGIN GAME", 20, 20, 40, Color.LIGHTGRAY);

                        break;

                    case "createAPet": //make colour pick a switch statement inside createAPet

                    Raylib.DrawText("PRESS ENTER TO CONFIRM COLOUR", 20, 20, 40, Color.LIGHTGRAY);
                    Raylib.DrawText("RIGHT TO TOGGLE BETWEEN COLOUR", 20, 70, 20, Color.LIGHTGRAY);
                    
                        t1.Draw();


                        t1.PickColourOfPet();
                        


                        break;


                    case "petScreen":


                    t1.Draw();

                    

                    break;


                }

                Raylib.EndDrawing();

            }
        }

    }
}
