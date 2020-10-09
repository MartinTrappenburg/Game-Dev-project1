using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    // Start is called before the first frame update

    private enum  States
    {
        start,
        intro1,
        intro2,
        delen,
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
        Terminal.WriteLine("This is story entirely based on a true events.");
        Terminal.WriteLine("Type 'start' to start the game");
    }

    void OnUserInput(string input) 
    {
       switch (currentState)
       {
           case States.start:
           StartIntro();
           break;
       }
         
    }

    void StartIntro()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Test");
        Terminal.WriteLine("Hier hebben we verhaal deel 2");
        Terminal.WriteLine("vergeet deel 3 van het verhaal niet");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
