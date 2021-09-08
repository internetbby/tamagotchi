using System;

namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string userAction; 

            string[] validResponses = {"a" , "b", "c", "feed", "say hi!", "say", "say hi", "teach word", "teach" , "d" , "stat", "get stat" , "get pet stat"};
            Tamagotchi firstPet = new Tamagotchi();
            while(firstPet.isAlive){
                while (firstPet.name == ""){
                    System.Console.WriteLine("please name me!");
                    firstPet.name = Console.ReadLine(); 

                    if (firstPet.name != ""){
                        System.Console.WriteLine("My name is now " + firstPet.name);
                    }
                }

                Console.ReadLine();
                
                System.Console.WriteLine("what do you wanna do");
                System.Console.WriteLine("a) Feed   b) Say hi!     c) Teach Word  d)Get Pet Stat");

                userAction = Console.ReadLine();

                userAction = toLower(userAction); 

                bool userChosenAction = isValidResponse(userAction, validResponses);

                if(userChosenAction == true){
                    firstPet.Tick();
                    switch (userAction){
                        case "a": 
                        case "feed":
                        firstPet.Feed();

                        System.Console.WriteLine("yum!");
                        break;

                        case "b":
                        case "say hi":
                        case "say hi!":
                        firstPet.Hi();
                        break; 

                        case "c":
                        case "teach":
                        case "teach word":
                        System.Console.WriteLine("what word should I learn?");
                        string learntWord = Console.ReadLine();
                        while (learntWord == ""){
                            System.Console.WriteLine("tell me a word to learn :(");
                            learntWord = Console.ReadLine();
                        }
                        firstPet.Teach(learntWord);
                        System.Console.WriteLine(firstPet.name + " learnt the word " + '"' + learntWord +'"');

                        break; 

                        case "d":
                        case "stat":
                        case "get stat":
                        case "get pet stat": 
                        firstPet.PrintStats();

                        break; 

                        
                    }

                    
                }
                else{
                    System.Console.WriteLine("not valid resposne");
                }

                


            }
        }

        static string toLower(string userAction){
           userAction =  userAction.ToLower();

           return userAction; 
        }

        static bool isValidResponse (string userResponse, string[] validResponses){

             bool validResponseCheck = false; 

            for(int i = 0; i< validResponses.Length ; i++){
                if (userResponse == validResponses[i]){

                   validResponseCheck = true;
                }
                
            }

            return validResponseCheck; 
        }
    }
}
