using System;
using System.Collections.Generic;
using Raylib_cs;


class Tamagotchi{

    public int x= 100;
    public int y= 100; 

    public int size = 300;

    public Color colourOfPet = Color.BEIGE;

    public Tamagotchi(){

        Rectangle r1 = new Rectangle (x, y,size,size);
       Raylib.DrawRectangleRec(r1, colourOfPet);
    }


    public void PickColourOfPet(){
        if(Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)){
            colourOfPet = Color.BLACK;


        }

    }
  

 
}