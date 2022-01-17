using System;
using System.Collections.Generic;
using Raylib_cs;


class Tamagotchi
{



    private int indexOfColour = 0;
    public const int x = 100;
    public const int y = 100;

    public const int size = 300;

    private Color[] colourOption = { Color.RED, Color.BLUE, Color.GREEN, Color.GRAY };

    public Color colourOfPet = Color.BLANK;

    private Rectangle r1 = new Rectangle(x, y, size, size);
    public Tamagotchi()
    {

        // Raylib.ClearBackground(Color.RAYWHITE);


        colourOfPet = colourOption[0];

        PickColourOfPet();

        Draw();

        // Raylib.DrawRectangleRec(r1, colourOfPet);

    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(r1, colourOfPet);
    }


    public void PickColourOfPet()
    {


        if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT))
        {
            colourOfPet = colourOption[indexOfColour];

            indexOfColour++;
            System.Console.WriteLine(indexOfColour);

            if (indexOfColour == colourOption.Length)
            {
                indexOfColour = 0;
            }
        }




    }



}