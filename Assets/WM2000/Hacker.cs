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
        Currentscreen = Screen.Mainmenu; 
        Terminal.ClearScreen();
        Terminal.WriteLine("HI");
        Terminal.WriteLine("HACK THIS TERMINAL {**}");
        Terminal.WriteLine("Press 1 for your Local Host Library");
        Terminal.WriteLine("Press 2 for your Server Host Library");
        Terminal.WriteLine("Type menu for menu");
        Terminal.WriteLine("ENTER YOUR CHOICE:");
    }
    // Update is called once per frame

    int Level;
    String Password;

    enum Screen { Mainmenu , Password , Win }
    Screen Currentscreen = Screen.Mainmenu;

    void OnUserInput(string Input )
    {
        Terminal.ClearScreen();
        if (Input == "menu")
        {
            ShowMainMenu();
        }

        else if (Currentscreen == Screen.Mainmenu)
        {
            runmainmenu(Input);
        }

        else if (Currentscreen == Screen.Password)
        {
            passwordcheck(Input);
        }
        
    }

    void runmainmenu(string Input)
    {
        if (Input == "1")
        {
            Level = 1;
            Password = "hack";
            startgame(Level);
        }

        if (Input == "2")
        {
            Level = 2;
            Password = "hack";
            startgame(Level);
        }

        else if (Input == "007")
        {
            Terminal.WriteLine("HEY!BOND STAY IN LIMITS!ENTER ONLY LEVEL");
        }

       
    }

    void startgame(int Level)
    {
        Currentscreen = Screen.Password;
        //Terminal.ClearScreen();
        Terminal.WriteLine("You Have Choosen Level : " + Level);
        Terminal.WriteLine("Enter The Password : ");
    }

    void passwordcheck(String Input)
    {
        if(Input == Password)
        {
            Terminal.WriteLine("YOU HACKED THE TERMINAL!");
        }
        else
        {
            Terminal.WriteLine("WRONG PASSWORD");
        }
    }

    void Update()
    {
        
    }
}
