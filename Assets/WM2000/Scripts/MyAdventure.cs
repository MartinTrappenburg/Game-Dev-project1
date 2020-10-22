using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update\
    /* 2 possible options for the If statements.
        if (State) {
             if(input == action1) {
             }
             if(input == action2) {
            
             }
             if(input == action3) {
            
             }
             if(input == action4) {
            
             }
             if(input == action5) {
            
             }
        }

        Other option I've got is this:
        if (input == "Continue") {
            if(currentstate == States.State1) {
            
             }
             if(currentstate == States.State2) {
            
             }
             if(currentstate == States.State3) {
            
             }
             if(currentstate == States.State4) {
            
             }
             if(currentstate == States.State5) {
            
             }
}
    */

    private enum  States
    {
        start,
        StartIntro,
        Ignore,
        Continue,
        Continue2,
        Continue3,
        Accept,
        Share,
        ShareYes,
        ShareYes2,
        Continue4,
        Continue5,
        Downstairs,
        Flashlight,
        Continue6,
        Run,
        Jump,
        Neighbours,
        Running,
    }

    private States currentState = States.start;

    void Start()
    {
        print("Hello World");
        Terminal.WriteLine("In de Terminal");
        ShowMainMenu(); 
    }

    void ShowMainMenu() 
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("This is Horrornite");
        Terminal.WriteLine("This story is entirely based on a true events.");
        Terminal.WriteLine("The game is case sensitive. Please use the same capitalisation as the options listed");
        Terminal.WriteLine("Type 'start' to start the game");
    }

    void OnUserInput(string input) 
    {
        if (input == "Reset")
        {
            currentState = States.start;
            ShowMainMenu();   
        }
        if (input == "Continue") {
            if(currentState == States.Ignore) {
                Continue();
             }
             if(currentState == States.Continue) {
                 Continue2();
             }
             if(currentState == States.Continue2) {
                 Continue4();
             }
             if(currentState == States.ShareYes) {
                 Continue3();
             }
             if(currentState == States.Accept) {
                 Continue4();
             }
             if(currentState == States.Continue4) {
                 Continue5();
             }
             if(currentState == States.Continue5) {
                 Share();
             }
             if(currentState == States.Flashlight) {
                 Continue6();
             }
             if(currentState == States.Downstairs) {
                 Continue6();
             }
             if(currentState == States.Jump) {
                 Continue7();
             }
             if(currentState == States.Running) {
                 Continue8();
             }
        }
       switch (currentState)    {
           case States.start: 
                if (input == "start") 
                {
                    StartIntro();
                 } else if (input == "Reset")
                 {
                     print("Game has been reset");
                 } else
                 {
                    Terminal.WriteLine("That command does not exist");
                 }
            break;

            case States.StartIntro:
                if (input == "Accept")
                {
                    Accept();
                } else
                if (input == "Ignore")
                {
                    Ignore();
                } else
                if (input == "Reset")
                {
                    print("Game has been reset");
                } else
                {
                   Terminal.WriteLine("That command does not exist");
                }
            break;

            case States.Share:
                if (input == "Tell")
                {
                    Tell();
                }else if (input == "Reset")
                 {
                     print("Game has been reset");
                 } 
            break;

            case States.Continue3:
                if (input == "Downstairs")
                {
                    Downstairs();
                }else if (input == "Flashlight")
                {
                    Flashlight();
                }
            break;

            case States.Continue6:
                if (input == "Run")
                {
                    Run();
                } else if (input == "Jump")
                {
                    Jump();
                }
            break;
            
            case States.Run:
                if (input == "Neighbours")
                {
                    Neighbour();
                } else if (input == "Keep Running")
                {
                    Running();
                }
            break;
                //Old code for reference later. this doesn't work
           /* case States.Continue:
                if (input == "Continue" && currentState == States.Ignore) {
                    Continue();
                    print(currentState);
                }else{
                    Terminal.WriteLine("That command does not exist");
                }
            break;
            
            case States.Continue2:
                if (input == "Continue" && currentState == States.Continue)
                {
                    Continue2();
                }else
                 {
                    Terminal.WriteLine("That command does not exist");
                 }
            break;*/
            
            
            /*case States.Continue3:
                if (input == "Continue" && currentState == States.ShareYes)
                {
                    
                }
            break;*/
       }
    }

    
    void StartIntro()
    {
        currentState = States.StartIntro;
        Terminal.ClearScreen();
        Terminal.WriteLine("It's a cold winter evening.");
        Terminal.WriteLine("Your friends went offline a while ago but you're still playing.");
        Terminal.WriteLine("You're doing your thing when you get a message");
        Terminal.WriteLine("It seems someone from your last match wants to talk.");
        Terminal.WriteLine("You have to accept his friend request to see the message");
        Terminal.WriteLine("Type in 'Accept' or 'Ignore'");
    }

    void Accept() {
        currentState = States.Accept;
        Terminal.ClearScreen();
        Terminal.WriteLine("You accept the friend request and read the message.");
        Terminal.WriteLine("it reads: 'Last round was awesome, we worked really well together.'");
        Terminal.WriteLine("'Hey, I found this new event, have you seen it yet?.'");
        Terminal.WriteLine("You say: 'What new event?'");
        Terminal.WriteLine("Type 'Continue' to continue the story");
    }
  
    void Ignore() {
        currentState = States.Ignore;
        Terminal.ClearScreen();
        Terminal.WriteLine("You choose to ignore the friend request.");
        Terminal.WriteLine("You think to yourself: He probably wants to yell at me that I suck.");
        Terminal.WriteLine("Type 'Continue' to continue the story.");
    }

    void Continue() {
        currentState = States.Continue;
        Terminal.ClearScreen(); 
        Terminal.WriteLine("Suddenly a chatbox pops up.");
        Terminal.WriteLine("It reads: Hey, we played together last match. I found this cool new event, wanna try it?");
        Terminal.WriteLine("You wonder what's happening.");
        Terminal.WriteLine("You ask how he could send that message when you ignored the request.");
        Terminal.WriteLine("Type 'Continue' to continue the story");
    }

    void Continue2() {
        currentState = States.Continue2;
        Terminal.ClearScreen();
        Terminal.WriteLine("Another message pops in the chatbox.");
        Terminal.WriteLine("'You don't need to accept the request for me to message you.'");
        Terminal.WriteLine("You think to yourself 'Didn't know that!'");
        Terminal.WriteLine("You mentioned a cool new event?.");
        Terminal.WriteLine("Type 'Continue' to continue the story");
    }

     void Continue4() {
        currentState = States.Continue4;
        Terminal.ClearScreen();
        Terminal.WriteLine("'It's called Horrornite. The game is mostly the same but the map has been overhauled.");
        Terminal.WriteLine("They added a bunch of NPCs that chase you down and randomly attack you as well.");
        Terminal.WriteLine("It's really cool and a bit creepy. Wanna try it?");
        Terminal.WriteLine("You say: 'Sure, sounds awesome!'");
        Terminal.WriteLine("Type 'Continue' to continue the story.");
     }

     void Continue5() {
        currentState = States.Continue5;
        Terminal.ClearScreen();
        Terminal.WriteLine("He shows you how to access the event and you start playing it together.");
        Terminal.WriteLine("It's quite a lot of fun but also a bit creepy.");
        Terminal.WriteLine("Type 'Continue' to continue the story.");
     }

        void Share() {
        currentState = States.Share;
        Terminal.ClearScreen();
        Terminal.WriteLine("After a few fun hours he asks: 'Where do you live?'");
        Terminal.WriteLine("He follows up and says: 'I'm from the town of West in Texas.'");
        Terminal.WriteLine("You realize that he lives close to you. do you want to tell him?");
        Terminal.WriteLine("Type 'Tell' or 'Don't tell' to continue.");
    }

    void Tell() {
        currentState = States.ShareYes;
        Terminal.ClearScreen();
        Terminal.WriteLine("You think about it for a bit.");
        Terminal.WriteLine("because he sounds like he's around the same age as you and because you 2 seem to get along quite well,");
        Terminal.WriteLine("You tell him where you live.");
        Terminal.WriteLine("Type 'Continue' to continue the story");
    }

     void Continue3() {
        currentState = States.Continue3;
        Terminal.ClearScreen();
        Terminal.WriteLine("You talk a bit more and then decide to call it a night.");
        Terminal.WriteLine("You ask if he wants to play again tomorrow and he says he'll be online all day");
        Terminal.WriteLine("You go to bed and fall asleep quite quickly.");
        Terminal.WriteLine("About an hour later you wake up from a strange noise.");
        Terminal.WriteLine("Do you go downstairs to check it out or do you want to grab a flashlight first?");
        Terminal.WriteLine("Type Downstairs or Flashlight to continue the story");
     }
     
     void Flashlight() {
         currentState = States.Flashlight;
         Terminal.ClearScreen();
         Terminal.WriteLine("You grab your flashlight from the drawer and walk downstairs.");
         Terminal.WriteLine("When you enter the livingroom you see that oone of the windows isn't fully closed.");
         Terminal.WriteLine("'It was probably the wind' you think as you close the window.");
         Terminal.WriteLine("You go around the house to check the other windows.");
         Terminal.WriteLine("Type 'Continue' to continue the story.");

     }

     void Downstairs() {
        currentState = States.Downstairs;
        Terminal.ClearScreen();
        Terminal.WriteLine("You go downstairs to see what caused the noise.");
        Terminal.WriteLine("As you enter the livingroom you seet that the window isn't fully closed.");
        Terminal.WriteLine("You think to yourself: 'It probably didn't close properly and the wind made it move'");
        Terminal.WriteLine("You close the window and lock it. You go through tthe house and check the other windows");
        Terminal.WriteLine("Type 'Continue' to continue the story.");
     }

     void Continue6() {
         currentState = States.Continue6;
         Terminal.ClearScreen();
         Terminal.WriteLine("Suddenly you hear footsteps behind you and you turn around.");
         Terminal.WriteLine("You see a man in his 40s wearing black clothing holding a crowbar.");
         Terminal.WriteLine("He runs at you. What do you do?");
         Terminal.WriteLine("Type 'run' to run or 'jump' to jump out of his way");
     }

     void Jump() {
         currentState = States.Jump;
         Terminal.ClearScreen();
         Terminal.WriteLine("You try and jump out of the way but he is too quick and knocks you to the floor");
         Terminal.WriteLine("He pushes a rag into your face and after a short struggle you go unconscious.");
         Terminal.WriteLine("Some time later you wake up tied up in your basement with a severe headache.");
         Terminal.WriteLine("About an hour later the man comes down the stairs, walks over to some of the piping.");
         Terminal.WriteLine("He places a small device on the floor.");
         Terminal.WriteLine("He then takes a good look at the pipes on the wall and then smashes one of the pipes");
         Terminal.WriteLine("Write 'Continue' to continue the story");

     }
     
     void Continue7() {
         Terminal.ClearScreen();
         Terminal.WriteLine("He walks out of the room and locks the door.");
         Terminal.WriteLine("You quickly realize that he smashed the gaspipe and that the room is filling with gas");
         Terminal.WriteLine("Suddenly you hear a beep and the room bursts into flames.");
         Terminal.WriteLine("The house explodes and burns to the ground.");
         Terminal.WriteLine("The man is never found and your case goes cold");
         Terminal.WriteLine("The end. You died. Type 'Reset' to start over");
     }

     void Run() {
         currentState = States.Run;
         Terminal.ClearScreen();
         Terminal.WriteLine("You sturn around and sprint towards the back door throwing down objects behind you.");
         Terminal.WriteLine("You seem to be able to outrun the man as he struggles to move dodge the things you're throwing.");
         Terminal.WriteLine("You reach the backdoor and sprint out. What do you do?");
         Terminal.WriteLine("Type 'Neighbours' to sprint towards your neighbour's house or 'Keep running' to keep running");
     }

     void Neighbour() {
         currentState = States.Neighbours;
         Terminal.ClearScreen();
         Terminal.WriteLine("You sprint towards your neighbours house frantically knocking on the door when you arrive");
         Terminal.WriteLine("His porch light turns on and he opens the door, you sprint inside and slam the door shut behind you");
         Terminal.WriteLine("You explain what's going on as your neighbour calls the police.");
         Terminal.WriteLine("The man is found a few hours later in an abandoned house 3 blocks away.");
         Terminal.WriteLine("He is convicted for several cases of burglary, murder and assault.");
         Terminal.WriteLine("You win. NEVER share your personal details online to someone you don't know.");
     }

     void Running() {
         currentState = States.Running;
         Terminal.ClearScreen();
         Terminal.WriteLine("You decide that running to your neighbour is too risky because you have to run past the man");
         Terminal.WriteLine("You keep sprinting for a few minutes in the direction of the nearest 24/7 store which is about 3 blocks away");
         Terminal.WriteLine("You decide to take a shortcut through an alleyway.");
         Terminal.WriteLine("Before you enter the alley you turn around and see the man in the distance looking at you.");
         Terminal.WriteLine("You reach the store out of breath and run in.");
         Terminal.WriteLine("Type Continue to finish the story");
     }

     void Continue8() {
         Terminal.ClearScreen();
         Terminal.WriteLine("The shopkeeper looks at you in an odd way but takes you into the back room and calls the police once he hears about what's happening.");
         Terminal.WriteLine("The police take your statement and a few hours later they arrest the man in an abandoned house a few blocks away.");
         Terminal.WriteLine("He is convicted on multiple charges of Murder, Assault, Burglary and Theft.");
         Terminal.WriteLine("You win. You Survived. NEVER share your personal details online to someone you don't know.");
     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
