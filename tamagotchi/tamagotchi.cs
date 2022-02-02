using System;
using System.Collections.Generic;
using System.Timers;
using Raylib_cs;


 class Tamagotchi
{

    private int indexOfColour = 0;
    private const int x = 100;
    private const int y = 100;

    private const int size = 300;

    protected int hunger = 10;

    protected int boredom = 10;

    protected int dirtiness = 10;

    private Color[] colourOption = { Color.RED, Color.BLUE, Color.GREEN, Color.GRAY };

    public Color colourOfPet = Color.BLANK;

    private Rectangle r1 = new Rectangle(x, y, size, size);
    public Tamagotchi()
    {

        setTimer();

        // Raylib.ClearBackground(Color.RAYWHITE);


        colourOfPet = colourOption[0];

        PickColourOfPet();

        Draw();

        // Raylib.DrawRectangleRec(r1, colourOfPet);

    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(r1, colourOfPet);
        System.Console.WriteLine(hunger);
    }

    public void setTimer()
    {
        var aTimer = new System.Timers.Timer(2000); // fire every 1 second
        aTimer.Elapsed += TimerOver;
        aTimer.AutoReset = true;
        aTimer.Enabled = true; 
    }

    public virtual void TimerOver(object sender, System.Timers.ElapsedEventArgs e)
    {
        hunger--;
        boredom--;
        dirtiness--;

        System.Console.WriteLine(hunger + boredom + dirtiness);
    
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