using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }


    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("HI");
        print("Hello Console");
        Terminal.WriteLine("HACK THIS TERMINAL {**}");
        Terminal.WriteLine("Press 1 for your Local Host Library");
        Terminal.WriteLine("Press 2 for your Server Host Library");
        Terminal.WriteLine("Press 3 for your Doing nothing");
        Terminal.WriteLine("ENTER YOUR CHOICE:");
    }
    // Update is called once per frame

    int Level;

    void OnUserInput(string Input )
    {
        if(Input == "menu")
        {
            ShowMainMenu();
        }

        else if(Input == "1")
        {
            Level = 1;
            startgame(Level);
        }

        else if(Input == "007")
        {
            Terminal.WriteLine("HEY!BOND STAY IN LIMITS!ENTER ONLY LEVEL");
        }

        else
        {
            Terminal.WriteLine("ENTER A VALID CHOICE ");
        }
    }

    void startgame(int Level)
    {
        Terminal.WriteLine("You Have Choosen " + Level);
    }

    void Update()
    {
        
    }
}
