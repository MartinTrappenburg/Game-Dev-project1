using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update

    private enum  States
    {
        start,
        Ignore,
        Continue,
        Accept,
        Share,
        deelnee,
        deelja,
        leukgesprek,
        deeltadres,
        nacht,
        checksloten,
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
       switch (currentState)
       {
           case States.start:
           StartIntro();
           if (input == "Accept")
           {
               currentState = States.Accept;
               Accept();
           }
           if (input == "Ignore")
           {
               currentState = States.Ignore;
               Ignore();
           }
           break;
           case States.Continue:
            Continue();
           break;
           case States.Share:
           Share();
           break;
       }
       print("Arjan");  
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It's a cold winter evening.");
        Terminal.WriteLine("Your friends went offline a while ago but you're still playing.");
        Terminal.WriteLine("You're doing your thing when you get a message");
        Terminal.WriteLine("It seems someone from your last match wants to talk.");
        Terminal.WriteLine("You have to accept his friend request to see the message");
        Terminal.WriteLine("Type in 'Accept' or 'Ignore'");
    }

    void Accept() {
        Terminal.ClearScreen();
        Terminal.WriteLine("You accept the friend request and read the message.");
        Terminal.WriteLine("it reads: 'Last round was awesome, we worked really well together.'");
        Terminal.WriteLine("You keep talking for a bit and play a few more games together.");
    
    }

    void Share() {
        Terminal.ClearScreen();
        Terminal.WriteLine("Eventually he asks: 'Where do you live?");
        Terminal.WriteLine("'I live in the town of West in Texas.'");
        Terminal.WriteLine("You realize that he lives close to you. do you want to tell him?");
    }

    
    void Ignore() {
        Terminal.ClearScreen();
        Terminal.WriteLine("You choose to ignore the friend request.");
        Terminal.WriteLine("You think to yourself: He probably wants to yell at me that I suck.");
        Terminal.WriteLine("Type 'Continue' to continue the story.");
    }

    void Continue() {
        Terminal.WriteLine("It reads: Hey, we played together last match. I found this cool new event, wanna try it?");
        Terminal.WriteLine("Choose your response:");
        Terminal.WriteLine("'Who are you?' or 'How did you send this message?'");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
