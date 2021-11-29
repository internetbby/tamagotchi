using System;
using System.Collections.Generic;
using Raylib_cs;

namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
             Raylib.InitWindow(800,600, "Tamagotchi"); //Initilization 

             string currentScreen = "title"; //adding a sort of function to switch screens

             List<string> tamagotchi  = new List<string>();


            Raylib.SetTargetFPS(60);
                    Tamagotchi t1 = null;

            while(!Raylib.WindowShouldClose()){ //Main game loop

                List<string> tamagotchisOWned  = new List<string>();

                switch(currentScreen){ //Game logic
                    case "title":

                    if(Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)){
                        if(tamagotchisOWned.Count < 1){
                            currentScreen = "createAPet";
                        }
                        else{
                            currentScreen = "petOwned";
                        }
                    }
                    
                    break;

                    case "createAPet":
                    


                    break;


                }

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RAYWHITE);

                switch(currentScreen){ //Drawing on that screen
                    case "title":
                    //Draw title

                    Raylib.DrawText("PRESS ENTER TO BEGIN GAME", 20, 20, 40, Color.LIGHTGRAY);

                    break;

                    case "createAPet":

                    if (t1 == null)
                    {
                        t1 = new Tamagotchi();
                    }
                    //customization features added here! 
                    
                    t1.PickColourOfPet();

                  
                    break;

                }

                Raylib.EndDrawing();

            }
        }

    }
}
