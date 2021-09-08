using System;
using System.Collections.Generic;

class Tamagotchi{
    private int hunger = 0; 

    private int boredom = 0; 

    private List<string> wordsKnown = new List<string>();

    public bool isAlive = true; 

    private Random generator = new Random();
    
    public string name = ""; 

    public void Tick() {
        hunger++; 
        boredom++;

        if(hunger == 10 || boredom == 10){
            isAlive = false; 
        }
    }

    public void Feed(){
        hunger -= 3; 
    }

    private void ReduceBoredom(){
        boredom-= 3;  
    }

    public void Teach(string word){
      //word =  Console.ReadLine();

      wordsKnown.Add(word);

      ReduceBoredom();
      
    }

    public void PrintStats(){
        Console.WriteLine("Boredom:" + boredom);
        Console.WriteLine ("Hunger:"+ hunger);

        if (isAlive == true){
            Console.WriteLine("I'm alive and healthy :)");
        }
        else {
            Console.WriteLine("RIP" + name); 
        }
    }
    public void Hi(){
        int wordChosen = generator.Next(wordsKnown.Count);

        if (wordsKnown.Count == 0){
            System.Console.WriteLine("I don't know any words yet");
        }
        else{
            System.Console.WriteLine('"' + wordsKnown[wordChosen] + '"');
            ReduceBoredom();
        }
        // add tick method after every action or when choosing action.. hm 
    }
            public void GetAlive (){
            if (boredom==10 || hunger == 10 ){
                isAlive = false; 
            }
            else{
                isAlive = true; 
            }
        }
}