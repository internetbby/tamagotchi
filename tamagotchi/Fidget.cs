using System.Timers;
using System;

class Fidget : Tamagotchi
{

    private int hungerDrainer = 2; 
    public override void TimerOver(object sender, System.Timers.ElapsedEventArgs e)
    {
        hunger = hunger - hungerDrainer;

    }
}

